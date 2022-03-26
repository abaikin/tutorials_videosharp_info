using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint2D
{
    public  class LevelScreen : GameScreen
    {
        protected int start_position_x;
        private Timer timer_alice_animation;
        private System.ComponentModel.IContainer components;
        protected int start_position_y;


        int cursorFrame = 0;
        public LevelScreen(){
            InitializeComponent();
            this.Shown += new System.EventHandler(this.FormLevelScreen_Shown);
        }
       
        virtual protected void start_level()
        {
            start_all_processes();
            // this.Cursor = new Cursor(Cursor.Current.Handle);
            string projectFolderPath;
            
            if(DesignMode){
                projectFolderPath = Directory.GetCurrentDirectory() + "\\Labirint2D";
            }else{
                projectFolderPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            }

            this.Cursor = new Cursor(projectFolderPath + "\\Images\\Cursors\\alice_frame_0.cur");
  
            Cursor.Position = PointToScreen(new Point(start_position_x, start_position_y));


            timer_alice_animation.Enabled = true;
        
            Sound.play_start();
            
        }
        protected void restart_level()
        {

            timer_alice_animation.Enabled = false;
            this.Cursor = new Cursor(Cursors.Arrow.Handle);
            if (screen_controller.checkRestartLevel() == System.Windows.Forms.DialogResult.Yes)
            {
                start_level();
            }
            else
            {

                this.DialogResult = System.Windows.Forms.DialogResult.Abort;

            }
        }
        private void FormLevelScreen_Shown(object sender, EventArgs e)
        {
            start_level();
        }

        public void finish_game()
        {


            stop_all_processes();
            this.Cursor = new Cursor(Cursors.Arrow.Handle);
            Sound.play_win();

            MessageBox.Show(
            "Вы прошли игру!!!",
            "Вы прошли игру",
            MessageBoxButtons.OK);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            
        }

        protected void finish_level()
        {

            stop_all_processes();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer_alice_animation = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer_alice_animation
            // 
            this.timer_alice_animation.Interval = 300;
            this.timer_alice_animation.Tick += new System.EventHandler(this.timer_alice_animation_Tick);
            // 
            // LevelScreen
            // 
            this.ClientSize = new System.Drawing.Size(1076, 576);
            this.Name = "LevelScreen";
            this.ResumeLayout(false);

        }

        private void timer_alice_animation_Tick(object sender, EventArgs e)
        {
            cursorFrame++;
            int frameNumber = cursorFrame % 3;
            string projectFolderPath;
            if (DesignMode)
            {
                projectFolderPath = Directory.GetCurrentDirectory() + "\\Labirint2D";
            }
            else
            {
                projectFolderPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            }
            this.Cursor = new Cursor( projectFolderPath + "\\Images\\Cursors\\alice_frame_" + frameNumber.ToString() + ".cur");
        }
        virtual protected void start_all_processes()
        {
            timer_alice_animation.Enabled = true;
        }
        virtual protected void stop_all_processes()
        {
            timer_alice_animation.Enabled = false;
        }
    }
}
