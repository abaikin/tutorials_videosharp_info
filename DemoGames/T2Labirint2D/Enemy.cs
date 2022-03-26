using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint2D
{
    class Enemy
    {
        public int x;
        public int y;

        public int width;
        public int height;

        public int vx;
        public int vy;

        public Label gr;

        public int frameNumber;

        public ArrayList frames;



        public Enemy(){

            x = 0;
            y = 0;
            width = 1;
            height = 1;
            vx = 0;
            vy = 0;
            gr = new Label();
            frameNumber = 0;
            frames = new ArrayList();
        
        }

        public Enemy(int toX, int toY, int toWidth, int toHeight)
        {
            x = toX;
            y = toY;
            height = toHeight;
            width = toWidth;
            gr = new Label();

            frameNumber = 0;
            frames = new ArrayList();

        }

        public void UpdatePosition(){

            x = x + vx;
            y = y + vy;

        }

        public void RedrawEnemy()
        {

            gr.Location = new Point(x, y);

        }



    }
}
