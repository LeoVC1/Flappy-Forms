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
    public partial class FrmPause : Form
    {
        private frm_Menu frm_Menu;

        public FrmPause(frm_Menu frm_Menu)
        {
            InitializeComponent();
            this.frm_Menu = frm_Menu;
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void btn_Resume_Click(object sender, EventArgs e)
        {
            frm_Menu.paused = false;
            this.Close();
        }
    }
}
