using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint2D
{
    public class GameScreen : Form
    {
        public ScreenController screen_controller;
        public GameScreen()
        {

            this.Size = new System.Drawing.Size(
                SystemInformation.VirtualScreen.Width * 8 / 10,
                SystemInformation.VirtualScreen.Height * 8 / 10);

        }


        ~GameScreen()  // destructor
        {
            
        }
    }
}
