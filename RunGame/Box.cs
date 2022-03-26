using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunGame
{
    class Box : Игрок
    {

        public Rectangle box { get; private set; }

        public Color color { get; private set; }

        int sx;
        int sy;

        public Box(int x, int y, int w, int h)
            :this(x,y,w,h,0,0)
        {
     
        }
        public Box(int x, int y, int w, int h,int sx,int sy)
        {
            box = new Rectangle(x, y, w, h);
            color = Color.Green;
            this.sx = sx;
            this.sy = sy;
        }
        void Игрок.Бежать()
        {
            Move();
        }

        private void Move()
        {
            int x = box.X + sx;
            int y = box.Y + sy;
            if (x < 0 || x > Arena.Range.Width - box.Width)
            {
                sx = -sx;
            }
            if (y < 0 || y > Arena.Range.Height - box.Height)
            {
                sy = -sy;
            }

            box = new Rectangle(box.X + sx, box.Y + sy, box.Width, box.Height);
        }
        void Игрок.Голя()
        {
            color = Color.Red;
        }

        void Игрок.НеГоля()
        {
            color = Color.Green;
        }

        bool Игрок.Поймал(Игрок that)
        {
            // http://xdan.ru/how-to-check-intersect-two-rectangles.html
            // http://stackoverflow.com/questions/306316/determine-if-two-rectangles-overlap-each-other


            Crosser crosser = new Crosser();
            return crosser.Cross(this, that);


            
        }

        //private bool Cross(Rectangle RectA, Rectangle RectB) {
        //    Crosser crosser = new Crosser();
        //    return crosser.Cross(c1, c2);
        //}
    }
}
