using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastClick
{
    public partial class Form1 : Form
    {

        long time_start;
        long time_stop;

        int max_counter = 10;
        int counter;
        string mode = "stop"; /* "stop" - the game is stopped */
        public Form1()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            start_game();
        }

        private void start_game()
        {
            if (mode == "play")
            {
                return;
            }
           
            mode = "play";
            
            counter = max_counter;
            label_counter.Text = counter.ToString();
            label_result.Text = "";
            button_start.Enabled = false;
            
        }

        private void play_game()
        {
            if (mode == "stop")
            {
                return;
            }

            if (counter == max_counter)
            {
                time_start = DateTime.Now.Ticks;
            }

            if (counter > 0)
            {
                counter--;
                
            }
            label_counter.Text = counter.ToString();

            if (counter == 0)
            {
                stop_game();
            }
        }

        private void stop_game()
        {
            time_stop = DateTime.Now.Ticks;
            double seconds = TimeSpan.FromTicks(time_stop - time_start).TotalSeconds;
            double click_per_second = max_counter / seconds;
            label_result.Text = click_per_second.ToString("#.#") + "clicks per sec";
            mode = "stop";
            button_start.Enabled = true;
        }

        private void label_counter_MouseDown(object sender, MouseEventArgs e)
        {
            play_game();
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Alexey Baykin.\nE-mail: alexey.baykin@gmail.com.","О программе", MessageBoxButtons.OK);
        }
    }
}
