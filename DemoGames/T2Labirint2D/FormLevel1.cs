using System;
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
    public partial class FormLevel1 : LevelScreen
    {

        int box_left = 6;
        public FormLevel1()
        {


            
            InitializeComponent();

            start_position_x = label_start.Location.X + label_start.Width / 2;
            start_position_y = label_start.Location.Y + label_start.Height / 2;

            Utilities.AddTextureToLabel(label1, Labirint2D.Properties.Resources.wall_rock_level_1);
            Utilities.AddTextureToLabel(label2, Labirint2D.Properties.Resources.wall_rock_level_1);
            Utilities.AddTextureToLabel(label3, Labirint2D.Properties.Resources.wall_rock_level_1);
            Utilities.AddTextureToLabel(label4, Labirint2D.Properties.Resources.wall_rock_level_1);
            Utilities.AddTextureToLabel(label5, Labirint2D.Properties.Resources.wall_rock_level_1);


            Utilities.AddTextureToFitLabel(label_start, Labirint2D.Properties.Resources.hole_start);

            Utilities.AddTextureToFitLabel(label_finish, Labirint2D.Properties.Resources.hole_finish);
            


           
        }

        private void label_finish_MouseEnter(object sender, EventArgs e)
        {
            if (box_left == 0)
            {
                finish_level();
            }
            else
            {
                MessageBox.Show("Not enough boxes collected!");
            }
           
        }

        
        private void label6_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).Visible = false;

            box_left--;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            restart_level();
        }

       
        override protected void start_level()
        {
            base.start_level();
            //Point point = label_start.Location;
            //point.Offset(label_start.Width / 2, label_start.Height / 2);
            //Cursor.Position = PointToScreen(point);

            //Sound.play_start();
            box_left = 6;
            label_box1.Visible = true;
            label_box2.Visible = true;
            label_box3.Visible = true;
            label_box4.Visible = true;
            label_box5.Visible = true;
            label_box6.Visible = true;

        }

        private void FormLevel1_Load(object sender, EventArgs e)
        {

        }


    }
}
