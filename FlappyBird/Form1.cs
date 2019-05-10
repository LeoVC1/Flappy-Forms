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
    public partial class frm_Menu : Form
    {
        private Timer t;
        private Timer spawn;
        List<Pipe> pipes = new List<Pipe>();
        Random rnd = new Random(DateTime.Now.Millisecond);
        bool paused;

        bool init = false;

        public frm_Menu()
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
                pipes.Add(new Pipe(this.ClientRectangle.Width - 50, (height + 100) * i,50,height + (500 * i), NewColor()));
            }
        }

        private void ResetGame()
        {
            btn_Play.Visible = true;
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            init = true;
            CreatePipes(sender, e);
            spawn = new Timer();
            spawn.Interval = 2500;
            spawn.Tick += new EventHandler(CreatePipes);
            spawn.Start();
            pbGameTitle.Visible = false;
            btn_Play.Visible = false;
            btn_Credits.Visible = false;
            btn_Quit.Visible = false;
            lbl_Info.Visible = false;
        }

        private void btn_Credits_Click(object sender, EventArgs e)
        {
            pbGameTitle.Visible = true;
            pb_Credits.Visible = true;
            btn_Play.Visible = false;
            btn_Credits.Visible = false;
            btn_Quit.Visible = false;
            btn_Back.Visible = true;
            pbGameTitle.Visible = false;
            lbl_Info.Visible = false;            
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            pbGameTitle.Visible = true;
            pb_Credits.Visible = false;
            btn_Play.Visible = true;
            btn_Credits.Visible = true;
            btn_Quit.Visible = true;
            btn_Back.Visible = false;
            lbl_Info.Visible = true;
        }

        private void frm_Menu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P || e.KeyCode == Keys.Escape)
            {
                Pause pause = new Pause();
                pause.Enabled = true;
                pause.Visible = true;
                spawn.Stop();
            }
        }
    }
}
