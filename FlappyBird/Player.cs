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
    class Player
    {
        Timer t;
        public float x, y, width, height, speed, jumpForce = -1.5f;
        public bool isJumping, isDead;
        public Rectangle collision;

        Brush playerColor = new SolidBrush(Color.DarkGreen);

        public Player(int argX, int argY, int argWidth, int argHeight)
        {
            x = argX;
            y = argY;
            width = argWidth;
            height = argHeight;
            Point rectPos = new Point(argX, argY);
            Size rectSize = new Size(argWidth, argHeight);
            collision = new Rectangle(rectPos, rectSize);
        }

        public void MovePlayer()
        {
            speed = isJumping == true ? speed : speed + 0.02f;
            y += speed;
            collision.Y = Convert.ToInt32(y);
        }

        public void DrawPlayer(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(playerColor, x, y, width, height);
        }

        public void Jump()
        {
            isJumping = true;
            if(t != null)
                t.Stop();
            t = new Timer();
            t.Interval = 1;
            t.Tick += new EventHandler(StopJump);
            t.Start();
            speed = jumpForce;
        }

        public void StopJump(object sender, EventArgs e)
        {
            if (speed < 0)
            {
                speed += 0.05f;
            }
            else
            {
                speed = 0;
                isJumping = false;
                t.Stop();
            }
        }

        public void CollisionAgainstForm(int formHeight)
        {
            if (y > formHeight - height)
            {
                isDead = true;
            }
            else if (y < 0 + height)
            {
                isDead = true;
            }
        }

        public void GameOver()
        {
            isDead = true;
        }
    }
}
