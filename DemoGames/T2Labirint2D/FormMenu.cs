using System;
using System.Windows.Forms;

namespace Labirint2D
{
    public partial class FormMenu : GameScreen
    {
        public FormMenu()
        {
            InitializeComponent();

            
        }

        private void button_start_Click(object sender, EventArgs e)
        {

            if (box_sound.Checked)
            {
                box_sound.Text = "Звук есть";
                Sound.sound_on();
            }
            else
            {
                Sound.sound_off();
                Sound.stop_all_sounds();
                box_sound.Text = "Звука нет";
            }
            start_level1();
        }

        private void start_level1()
        {
            //FormLevel1 level1 = new FormLevel1();
            //DialogResult dr = level1.ShowDialog();

            //if (dr == System.Windows.Forms.DialogResult.OK)
            //{
            //    start_level2();
            //}

            screen_controller.GoNextScreen();
            
        }

        public void start_level2()
        {
            FormLevel2 level2 = new FormLevel2();
            DialogResult dr = level2.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                Sound.play_win();
                MessageBox.Show("Победа! Вы прошли все уровни лабиринта!", "Ура!");
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void box_sound_CheckedChanged(object sender, EventArgs e)
        {
            if (box_sound.Checked)
            {
                box_sound.Text = "Звук есть";
                Sound.sound_on();
            }
            else
            {
                Sound.sound_off();
                Sound.stop_all_sounds();
                box_sound.Text = "Звука нет";
            }
            Sound.play_key();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
