using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint2D
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ScreenController screen_controller = new ScreenController();


            GameScreen first_application_screen = (GameScreen)screen_controller.game_screens[screen_controller.current_screen];

            Application.Run(first_application_screen);
        }
    }
}
