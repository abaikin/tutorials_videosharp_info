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
    public partial class FormLevel2 : LevelScreen
    {
        public FormLevel2()
        {
            InitializeComponent();

            Utilities.AddTextureToLabel(label1, Labirint2D.Properties.Resources.wall_rock_level_1);
            Utilities.AddTextureToLabel(label2, Labirint2D.Properties.Resources.wall_rock_level_1);
            Utilities.AddTextureToLabel(label3, Labirint2D.Properties.Resources.wall_rock_level_1);
            Utilities.AddTextureToLabel(label4, Labirint2D.Properties.Resources.wall_rock_level_1);
            Utilities.AddTextureToLabel(label5, Labirint2D.Properties.Resources.wall_rock_level_1);
            Utilities.AddTextureToLabel(label6, Labirint2D.Properties.Resources.wall_rock_level_1);
            Utilities.AddTextureToLabel(label7, Labirint2D.Properties.Resources.wall_rock_level_1);

            Utilities.AddTextureToLabel(label_flash1, Labirint2D.Properties.Resources.wall_rock_level_1);
            Utilities.AddTextureToLabel(label_flash2, Labirint2D.Properties.Resources.wall_rock_level_1);

            Utilities.AddTextureToLabel(label_door, Labirint2D.Properties.Resources.wood_door);

            Utilities.AddTextureToFitLabel(label_start, Labirint2D.Properties.Resources.hole_start);

            Utilities.AddTextureToFitLabel(label_finish, Labirint2D.Properties.Resources.hole_finish);
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
            label_flash1.Visible = !label_flash1.Visible;
            label_flash2.Visible = !label_flash2.Visible;
        }
        private void label2_MouseEnter(object sender, EventArgs e)
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

            label_flash1.Visible = false;
            label_flash2.Visible = true;

        }

        private void label_finish_Click(object sender, EventArgs e)
        {

        }

        private void FormLevel2_Load(object sender, EventArgs e)
        {

        }

        private void label_start_Click(object sender, EventArgs e)
        {

        }

        private void label_door_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

    }
}
