using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    class Pipe
    {

        int x;
        int y;
        int width;
        int height;
        Brush pipeColor;

        public Pipe(int argX, int argY, int argWidth, int argHeight, Brush argColor)
        {
            x = argX;
            y = argY;
            width = argWidth;
            height = argHeight;
            Brush brush = new SolidBrush(Color.Black);
            pipeColor = brush;
        }

        public void MovePipe(int speed)
        {
            x -= speed;
        }

        public void DrawPipe(object sender, PaintEventArgs e, int i)
        {
            int otherPos;
            if (i == 1)
                otherPos = y;
            else
                otherPos = y + height - 30;
            e.Graphics.FillRectangle(pipeColor, x, y, width, height);
            e.Graphics.FillRectangle(pipeColor, x - width + 30, otherPos, (width + width * 2) - 60, 30);
        }

    }
}
