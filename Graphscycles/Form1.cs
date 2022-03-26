using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphscycles
{
    public partial class Form1 : Form
    {

        Graphics g;
        Pen pen;

        public Form1()
        {
            InitializeComponent();
            initGraph();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void initGraph()
        {

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(pictureBox1.Image);
            pen = new Pen(Color.DarkRed);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }


        public void Clear()
        {

            g.Clear(pictureBox1.BackColor);
            RefreshPicture();
        }
        public void RefreshPicture()
        {

            pictureBox1.Refresh();
        }

        public void Sleep1()
        {
            RefreshPicture();
            Thread.Sleep(100);
        }
        public void Sleep2()
        {
            RefreshPicture();
            Thread.Sleep(20);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            g.DrawLine(pen, 0, 0, 300, 300);
            g.DrawLine(pen, 300, 0, 0, 300);
            RefreshPicture();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            for (int y = 0; y <= 300; y += 30)
            {
                g.DrawLine(pen, 0, y, 300, y);
                Sleep1();

            }
                
            

            RefreshPicture();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int x = 0; x <= 300; x += 30)
            {
                g.DrawLine(pen, x, 0, x, 300);
                Sleep1();
            }
                

            RefreshPicture();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int y = 0; y <= 300; y += 30)
            {
                g.DrawLine(pen, 0, y, 300, y);
                int x = y;
                g.DrawLine(pen, x, 0, x, 300);
                Sleep1();

            }
  


            RefreshPicture();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int a = 0; a <= 300; a += 30)
            {
               
                g.DrawLine(pen, 0, a, a, 0);
                
       
                Sleep1();

            }



            RefreshPicture();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int a = 0; a <= 300; a += 30)
            {

                g.DrawLine(pen, a, 300, 300, a);


                Sleep1();

            }


            RefreshPicture();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < 300; a += 30)
            {

                g.DrawLine(pen, 0, a, a, 0);


                Sleep1();
            }
            for (int a = 0; a <= 300; a += 30)     
            {
                g.DrawLine(pen, a, 300, 300, a);


                Sleep1();

            }


            RefreshPicture();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            for (int y = 0; y <= 300; y += 30)
            {
                g.DrawLine(pen, 0, 0, 300, y);
                Sleep1();
                g.DrawLine(pen, 0, 0, y, 300);
                Sleep1();
            }

            RefreshPicture();

        }

        private void button9_Click(object sender, EventArgs e)
        {

            for (int x = 300; x>= 0; x -= 30)
            {
                g.DrawLine(pen, 300, 300, x, 0);
                Sleep1();
                g.DrawLine(pen, 300, 300, 0, x);
                Sleep1();
            }

            RefreshPicture();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int y = 0; y <= 300; y += 30)
            {
                g.DrawLine(pen, 0, 0, 300, y);
                Sleep1();
                int x = y;
                g.DrawLine(pen, 300, 300, 0, x);
                Sleep1();
            }
        

           
            RefreshPicture();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            for (int y = 0; y <= 300; y += 30)
            {
                g.DrawLine(pen, 0, 300, y, 0);
                Sleep1();
                int x = y;
                g.DrawLine(pen, 0, 300, 300, x);
                Sleep1();
            }

            for (int y = 0; y <= 300; y += 30)
            {
                g.DrawLine(pen, 300, 0, 0, y);
                Sleep1();
                int x = y;
                g.DrawLine(pen, 300, 0, x, 300);
                Sleep1();
            }

            RefreshPicture();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < 300; y += 30)
            {
                for (int x = 0; x < 300; x += 30)
                {


                    g.DrawRectangle(pen, 3+x, 3+y, 24, 24);
                    Sleep2();
                }
            }
                
            RefreshPicture();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < 300; y += 30)
            {
                for (int x = 0; x < 300; x += 30)
                {


                    g.DrawRectangle(pen, 3 + x, 3 + y, 24, 24);
                    Sleep2();
                }
            }

            RefreshPicture();
        }
    }
}
