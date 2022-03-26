using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint2D
{
    class Utilities
    {

        public static void AddTextureToLabel(Label label, Image texture_image)
        {
  
            Bitmap bmp = new Bitmap(label.Width, label.Height);

            Image image = bmp;

            TextureBrush tBrush = new TextureBrush(texture_image);

            using (Graphics g = Graphics.FromImage(image))
            {
                // Modify the image using g here... 
                // Create a brush with an alpha value and use the g.FillRectangle function

                g.FillRectangle(tBrush, new Rectangle(0, 0, label.Width, label.Height));
            }   

            label.Image = image;
        }


        public static void AddTextureToFitLabel(Label label, Image texture_image)
        {

            label.Image = Utilities.ResizeImage(texture_image, label.Width, label.Width);

        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }



    }
}
