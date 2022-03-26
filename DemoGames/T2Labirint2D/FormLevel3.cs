using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint2D
{
    public partial class FormLevel3 : LevelScreen
    {


        ArrayList enemies;

        public FormLevel3()
        {
            InitializeComponent();

            Utilities.AddTextureToLabel(label1, Labirint2D.Properties.Resources.wood_wall_level_3);
            Utilities.AddTextureToLabel(label2, Labirint2D.Properties.Resources.wood_wall_level_3);

            Utilities.AddTextureToLabel(label4, Labirint2D.Properties.Resources.wood_wall_level_3);
            Utilities.AddTextureToLabel(label5, Labirint2D.Properties.Resources.wood_wall_level_3);
            Utilities.AddTextureToLabel(label6, Labirint2D.Properties.Resources.wood_wall_level_3);
            Utilities.AddTextureToLabel(label7, Labirint2D.Properties.Resources.wood_wall_level_3);
            Utilities.AddTextureToLabel(label8, Labirint2D.Properties.Resources.wood_wall_level_3);

            Utilities.AddTextureToFitLabel(label_start, Labirint2D.Properties.Resources.hole_start);

            Utilities.AddTextureToFitLabel(label_finish, Labirint2D.Properties.Resources.hole_finish);

            Utilities.AddTextureToLabel(label_door, Labirint2D.Properties.Resources.wood_door);

            enemies = new ArrayList();

            enemies.Add(new Enemy(Width / 2 + 40, Height / 2, 64, 45));


            foreach (Enemy enemy in enemies)
            {
                this.Controls.Add(enemy.gr);

                enemy.gr.Size = new Size(enemy.width, enemy.height);
                
                enemy.gr.BackColor = Color.Transparent;


                enemy.frames.Add(Properties.Resources.bat_frame_1);
                enemy.frames.Add(Properties.Resources.bat_frame_2);

                enemy.gr.Image = (Image)enemy.frames[1];

                enemy.gr.MouseEnter += new System.EventHandler(this.Enemy_MouseEnter);


                enemy.RedrawEnemy(); 

            }
            
            
        }

        private void label_finish_MouseEnter(object sender, EventArgs e)
        {

            finish_level();
        }

        private void label_key_MouseEnter(object sender, EventArgs e)
        {
            label_door.Visible = false;
            label_key.Visible = false;
            Sound.play_key();
        }

       

        private void timer_Tick(object sender, EventArgs e)
        {

            foreach (Enemy enemy in enemies)
            {

                int xOld = enemy.x;
                int yOld = enemy.y;


                Point cursorPosition = this.PointToClient(Cursor.Position);

                int xCursor = cursorPosition.X;
                int yCursor = cursorPosition.Y;

                double length = Math.Sqrt((xCursor - xOld) * (xCursor - xOld) + (yCursor - yOld) * (yCursor - yOld));

                double mult = 5.0;

                double vx = mult*(double)(xCursor - xOld)/length;
                double vy = mult*(double)(yCursor - yOld) / length;

                enemy.x = xOld + (int)vx;
                enemy.y = yOld + (int)vy;

            }


            foreach (Enemy enemy in enemies)
            {

                enemy.RedrawEnemy();

            }
        }
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            restart_level();
        }

        private void Enemy_MouseEnter(object sender, EventArgs e)
        {
            restart_level();
        }

        override protected void start_level()
        {

            base.start_level();

            Point point = label_start.Location;
            point.Offset(label_start.Width / 2, label_start.Height / 2);
            Cursor.Position = PointToScreen(point);

            Sound.play_start();

            label_door.Visible = true;
            label_key.Visible = true;


        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            restart_level();
        }

        private void timer_enemy_animation_Tick(object sender, EventArgs e)
        {


            foreach (Enemy enemy in enemies)
            {
                
                enemy.RedrawEnemy();

                int numberOfFrames = enemy.frames.Count;

                int nextFrameNum = (enemy.frameNumber + 1) % numberOfFrames;
                enemy.frameNumber = nextFrameNum;

                enemy.gr.Image = (Image)enemy.frames[enemy.frameNumber];

            }

        }
        override protected void start_all_processes()
        {
            base.start_all_processes();
            timer_enemy_animation.Enabled = true;
            timer.Enabled = true;
        }
        override protected void stop_all_processes()
        {
            base.stop_all_processes();
            timer_enemy_animation.Enabled = false;
            timer.Enabled = false;
        }

    }
}
