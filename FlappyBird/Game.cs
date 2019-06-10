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
        Player player;
        Random rnd = new Random(DateTime.Now.Millisecond);
        
        bool init, over = true;
        public bool paused;
        public int pontos = -1;

        public frm_Menu()
        {
            InitializeComponent();

            player = new Player(this.ClientRectangle.Width / 2, this.ClientRectangle.Width / 2, 30, 30);
        }

        private void t_Ticket(object sender, EventArgs e)
        {
            this.Refresh();
        }

        public void Form1_Load_1(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.Paint += new PaintEventHandler(GameLoop);
            t = new Timer();
            t.Interval = 10;
            t.Tick += new EventHandler(t_Ticket);
            t.Start();
            
            Frm_Rank rank = new Frm_Rank();
            rank.Form1_Load(sender, e);
        }

        private void GameLoop(object sender, PaintEventArgs e)
        {
            int i = 0;
            foreach (Pipe p in pipes)
            {
                if (paused != true)
                {
                    p.MovePipe(1);
                    spawn.Enabled = true;
                }
                else
                {
                    spawn.Enabled = false;
                }

                p.DrawPipe(sender, e, i);
                p.CollisionAgainstPlayer(player);
                i++;

                if (i == 2)
                    i = 0;
            }
            player.CollisionAgainstForm(this.ClientRectangle.Height);
            player.MovePlayer();
            player.DrawPlayer(sender, e);
            
            if (player.isDead == true && over == true)
            {
                over = false;
                End();
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
      
        public void End()
        {
            Frm_Rank over = new Frm_Rank {Visible = true };
            over.textBox2.Text = pontos.ToString();
            over.btn_Back.Visible = false;
            over.lbl_Rank.Text = "GAME OVER";
            paused = true;
        }

        public void Check(string name)
        {
            switch (name)
            {
                case "Start":
                    pn_Menu.Visible = false;
                    pn_Credits.Visible = false;
                    lbl_Score.Visible = true;
                    break;
                case "Credits":
                    pn_Credits.Visible = true;
                    pn_Menu.Visible = false;
                    break;
                case "BackToMenu":
                    pn_Menu.Visible = true;
                    pn_Credits.Visible = false;
                    break;
            }
        }

        private void frm_Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P || e.KeyCode == Keys.Escape)
            {
                FrmPause pause = new FrmPause(this);
                pause.Show();
                paused = true;
            }
        }

        private void frm_Menu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'w')
                player.Jump();
        }

        private void btn_Placar_Click(object sender, EventArgs e)
        {
            Frm_Rank rank = new Frm_Rank();
            rank.Visible = true;
            rank.btn_Gravar.Enabled = false;
            rank.btn_Restart.Enabled = false;
            rank.textBox1.Enabled = false;
            rank.LoadRank();
        }
    }
}
