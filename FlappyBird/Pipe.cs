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
        public int x, y, width, height;
        public Rectangle rectCollider = new Rectangle();
        public Rectangle pipeCollider = new Rectangle();
        public Brush pipeColor = new SolidBrush(Color.Black);

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
            e.Graphics.FillRectangle(new SolidBrush(Color.Yellow), x - width + 30, otherPos, (width + width * 2) - 60, 30);

            Size collSize = new Size(width, height);
            TransformCollider(x, y, collSize);

            Size rectSize = new Size((width + width * 2) - 60, 30);
            RectCollider(x - width + 30, otherPos, rectSize);
        }

        void RectCollider(int rectX, int rectY, Size rectSize)
        {
            rectCollider.Location = new Point(rectX, rectY);
            rectCollider.Size = rectSize;
        }
        void TransformCollider(int rectX, int rectY, Size rectSize)
        {
            pipeCollider.Location = new Point(rectX, rectY);
            pipeCollider.Size = rectSize;
        }

        public void CollisionAgainstPlayer(Player player)
        {
            if (this.rectCollider.IntersectsWith(player.collision) || this.pipeCollider.IntersectsWith(player.collision))
            {
                player.GameOver();
            }
        }
    }
}
