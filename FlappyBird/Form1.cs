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
        private int index = 0;
        Brush[] brushes = new Brush[10];
        Random rnd = new Random(DateTime.Now.Millisecond);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.Paint += new PaintEventHandler(GameLoop);
            t = new Timer();
            t.Interval = 10;
            t.Tick += new EventHandler(t_Ticket);

            t.Start();
        }

        private void t_Ticket(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void GameLoop(object sender, PaintEventArgs e)
        {
            ResetGame();
        }
        private Brush newColor()
        {
            int r = rnd.Next(0, byte.MaxValue + 1);
            int g = rnd.Next(0, byte.MaxValue + 1);
            int b = rnd.Next(0, byte.MaxValue + 1);
            Brush brush = new SolidBrush(Color.FromArgb(r, g, b));
            return brush;
        }

        private void ResetGame()
        {
            
        }


    }
}
