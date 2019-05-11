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
        
        bool init;
        bool paused;
        int pontos = -1;

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
                p.MovePipe(1);
                p.DrawPipe(sender, e, i);
                i++;
                if (i == 2)
                    i = 0;
            }
            lbl_Score.Text = pontos.ToString();
        }
        
        public void CreatePipes(object sender, EventArgs e)
        {
            int height = rnd.Next(100, 400);
            for (int i = 0; i < 2; i++)
                pipes.Add(new Pipe(this.ClientRectangle.Width - 50, (height + 100) * i,50, height + (500 * i)));

            pontos++;
        }

        private void ResetGame(){btn_Play.Visible = true;}

        private void btn_Play_Click(object sender, EventArgs e)
        {
            init = true;
            CreatePipes(sender, e);
            spawn = new Timer();
            spawn.Interval = 2500;
            spawn.Tick += new EventHandler(CreatePipes);
            spawn.Start();
            Check("Start");
        }

        private void btn_Credits_Click(object sender, EventArgs e){Check("Credits");}

        private void btn_Back_Click(object sender, EventArgs e){Check("BackToMenu");}

        private void btn_Quit_Click(object sender, EventArgs e){Application.Exit();}
        
        private void frm_Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P || e.KeyCode == Keys.Escape)
            {
                FrmPause pause = new FrmPause();
                pause.Enabled = true;
                pause.Visible = true;
            }
        }

        public void Check(string name)
        {
            switch (name)
            {
                case "Start":
                    pbGameTitle.Visible = false;
                    btn_Play.Visible = false;
                    btn_Credits.Visible = false;
                    btn_Quit.Visible = false;
                    lbl_Info.Visible = false;
                    lbl_Score.Visible = true;
                    break;
                case "Credits":
                    pbGameTitle.Visible = true;
                    pb_Credits.Visible = true;
                    btn_Play.Visible = false;
                    btn_Credits.Visible = false;
                    btn_Quit.Visible = false;
                    btn_Back.Visible = true;
                    pbGameTitle.Visible = false;
                    lbl_Info.Visible = false;
                    break;
                case "BackToMenu":
                    pbGameTitle.Visible = true;
                    pb_Credits.Visible = false;
                    btn_Play.Visible = true;
                    btn_Credits.Visible = true;
                    btn_Quit.Visible = true;
                    btn_Back.Visible = false;
                    lbl_Info.Visible = true;
                    break;
            }
        }
    }
}
