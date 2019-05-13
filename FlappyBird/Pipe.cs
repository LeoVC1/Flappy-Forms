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
        int x, y, width, height;
        public Rectangle rectCollider = new Rectangle();
        Brush pipeColor = new SolidBrush(Color.Black);

        public Pipe(int argX, int argY, int argWidth, int argHeight)
        {
            x = argX;
            y = argY;
            width = argWidth;
            height = argHeight;
            Brush brush = new SolidBrush(Color.Black);
        }

        public void MovePipe(int speed)
        {
            x -= speed;
        }

        public void DrawPipe(object sender, PaintEventArgs e, int i)
        {
            int otherPos;

            i = i == 1 ? otherPos = y : otherPos = y + height - 30;
            e.Graphics.FillRectangle(pipeColor, x, y, width, height);
            e.Graphics.FillRectangle(pipeColor, x - width + 30, otherPos, (width + width * 2) - 60, 30);

            Size collSize = new Size((width + width * 2) - 60, 30);
            TransformCollider(x - width + 30, otherPos, collSize);
        }

        void TransformCollider(int rectX, int rectY, Size rectSize)
        {
            rectCollider.Location = new Point(rectX, rectY);
            rectCollider.Size = rectSize;
        }

    }
}
