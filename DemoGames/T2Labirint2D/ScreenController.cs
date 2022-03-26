using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint2D
{
    public class ScreenController
    {

        private ArrayList _game_screens;

        public int current_screen;

        public int first_screen_index;

        public ScreenController()
        {
            
            _game_screens = new ArrayList();
            _game_screens.Add(new FormMenu());
            _game_screens.Add(new FormLevel1());
            _game_screens.Add(new FormLevel2());
            
            
            _game_screens.Add(new FormLevel3());
            
           

            foreach (GameScreen game_screen in _game_screens)
            {
                game_screen.screen_controller = this;
            }


            current_screen = 0;
            first_screen_index = 0;

        }

        /***************** Methods **********************/

        public void GoNextScreen()
        {

            if (current_screen + 1 >= _game_screens.Count)
            {

                ((LevelScreen)game_screens[current_screen]).finish_game();
                GoFirstScreen();
                
            }
            else
            {
                
                GameScreen level1 = (GameScreen)game_screens[current_screen + 1];
                current_screen++;

                ((GameScreen)game_screens[first_screen_index]).Hide();
                DialogResult dr = level1.ShowDialog();

                switch (dr)
                {
                    case DialogResult.OK:
                        GoNextScreen();
                        break;
                    case DialogResult.Abort:
                        GoFirstScreen();
                        break;
                    default:
                        GoFirstScreen();
                        break;
                }
         
            }
        }

        private void GoFirstScreen()
        {
            ((GameScreen)game_screens[first_screen_index]).Show();
            current_screen = 0;
            /* nothing to do */
            /* Currently we go to first screen automatically */
        }

        public DialogResult checkRestartLevel()
        {
            Sound.play_fail();
            return MessageBox.Show(
            "Выходить за рамки лабиринта нельзя.\nБудем еще раз играть?",
            "Вы проиграли!",
            MessageBoxButtons.YesNo);
            
        }

        /***************** Properties *******************/

        public ArrayList game_screens
        {

            set {
             
                _game_screens = new ArrayList(value);
                      
            }

            get {
                return this._game_screens;
            }
        }
    }
}
