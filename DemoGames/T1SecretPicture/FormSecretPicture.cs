using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretPicture
{
    public partial class FormSecretPicture : Form
    {

        int secret_nr = 0;
        public FormSecretPicture()
        {
            InitializeComponent();
        }

        private void FormSecretPicture_Load(object sender, EventArgs e)
        {

        }

        private void ButtonShow1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.autumn_1;
            secret_nr = 0;
        }

        private void ButtonShow2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.coast_2;
            secret_nr = 0;
        }

        private void ButtonShow3_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.rails_3;
            secret_nr = 0;
        }

        private void ButtonShow4_Click(object sender, EventArgs e)
        {
            if (secret_nr == 2)
            {
                this.BackgroundImage = Properties.Resources.tree_secret;
                secret_nr = 0;
            }
            else
            {
                this.BackgroundImage = Properties.Resources.road_4;
            }
            
        }

        private void FormSecretPicture_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                
                secret_nr = 1;
            }
        }

        private void FormSecretPicture_MouseMove(object sender, MouseEventArgs e)
        {
            if(secret_nr == 1)
                if(e.X < ButtonShow1.Location.X &&
                   e.Y < ButtonShow1.Location.Y)
                {
                    secret_nr = 2;
                }
        }
    }
}
