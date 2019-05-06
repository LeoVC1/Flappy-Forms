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
    public partial class Form1 : Form
    {
        private Timer t;
        private Timer spawn;
        List<Pipe> pipes = new List<Pipe>();
        Random rnd = new Random(DateTime.Now.Millisecond);

        bool init = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void t_Ticket(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.Paint += new PaintEventHandler(GameLoop);
            t = new Timer();
            t.Interval = 10;
            t.Tick += new EventHandler(t_Ticket);
            t.Start();
        }


        private void GameLoop(object sender, PaintEventArgs e)
        {
            int i = 0;
            foreach (Pipe p in pipes)
            {
                p.MovePipe(2);
                p.DrawPipe(sender, e, i);
                i++;
                if (i == 2)
                    i = 0;
            }
        }
        private Brush NewColor()
        {
            int r = rnd.Next(0, byte.MaxValue + 1);
            int g = rnd.Next(0, byte.MaxValue + 1);
            int b = rnd.Next(0, byte.MaxValue + 1);
            Brush brush = new SolidBrush(Color.FromArgb(r, g, b));
            return brush;
        }

        public void CreatePipes(object sender, EventArgs e)
        {
            int height = rnd.Next(100, 400);
            for (int i = 0; i < 2; i++)
            {
                pipes.Add(
                new Pipe(
                    this.ClientRectangle.Width - 50,
                    (height + 100) * i,
                    50,
                    height + (500 * i),
                    NewColor()
                ));
            }
        }

        private void ResetGame()
        {
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            init = true;
            CreatePipes(sender, e);
            spawn = new Timer();
            spawn.Interval = 2500;
            spawn.Tick += new EventHandler(CreatePipes);
            spawn.Start();
            button1.Visible = false;
            label1.Visible = false;
        }

    }
}
