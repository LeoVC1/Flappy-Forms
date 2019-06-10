using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace FlappyBird
{
    public partial class Frm_Rank : Form
    {
        frm_Menu menu = new frm_Menu();
        DataTable Dt = new DataTable();
        List<Data> ranking = new List<Data>();
        int cnt;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "zePpnHYjTHuBNl8CcjTXz2pIchjM6lWl9NKLRrlR",
            BasePath = "https://flappy-879e6.firebaseio.com/"
        };

        IFirebaseClient client;

        public Frm_Rank()
        {
            InitializeComponent();
        }

        public async void Form1_Load(object sender, EventArgs e)
        {
            ConnectFire();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Export();
        }

        public async void Save2()
        {
            FirebaseResponse response = await client.GetAsync("Information/" + textBox1.Text);
            Data Obj = response.ResultAs<Data>();

            textBox1.Text = Obj.Nome;
            textBox2.Text = Obj.Pontos.ToString();
        }

        public async void Save()
        {
            FirebaseResponse resp = await client.GetAsync("Counter/node");
            Counter_Class get = resp.ResultAs<Counter_Class>();

            MessageBox.Show(get.Cnt);
            var data = new Data
            {
                Id = (Convert.ToInt32(get.Cnt) + 1).ToString(),
                Nome = textBox1.Text,
                Pontos = Convert.ToInt32(textBox2.Text)
            };

            SetResponse response = await client.SetAsync("Information/" + data.Id, data);
            Data result = response.ResultAs<Data>();

            MessageBox.Show($"Pontuação do jogador '{result.Nome.ToUpper()}' salva com sucesso!");

            var obj = new Counter_Class { Cnt = data.Id };

            SetResponse response1 = await client.SetAsync("Counter/node", obj);

            btn_Gravar.Enabled = false;
            btn_Back.Enabled = false;
        }

        public async void Export()
        {
            Dt.Rows.Clear();
            int i = 0;
            FirebaseResponse Resp1 = await client.GetAsync("Counter/node");
            Counter_Class obj1 = Resp1.ResultAs<Counter_Class>();
            int cnt = Convert.ToInt32(obj1.Cnt);

            while (true)
            {

                if (i == cnt)
                {
                    break;
                }
                i++;
                try
                {
                    FirebaseResponse Resp2 = await client.GetAsync("Information/" + i);
                    Data Obj2 = Resp2.ResultAs<Data>();

                    DataRow row = Dt.NewRow();
                    row["Id"] = Obj2.Id;
                    row["Nome"] = Obj2.Nome;
                    row["Pontos"] = Obj2.Pontos;

                    Dt.Rows.Add(row);
                }
                catch{}
            }
            dgv_Rank[0, 2].ValueType = typeof(DateTime);
            dgv_Rank.Sort(dgv_Rank.Columns[2], ListSortDirection.Descending);
            btn_Back.Visible = true;
        }

        public void LoadRank()
        {
            dgv_Rank.Visible = true;
            int l = 0;
            while (true)
            {
                if (l == cnt)
                    break;
       
                l++;
                try
                {
                    Data repos;
                    for (int i = 0; i < cnt; i++)
                    {
                        for (int j = 0; j < cnt - (i + 1); j++)
                        {
                            if (ranking[j].Pontos < ranking[j + 1].Pontos)
                            {
                                repos = ranking[j];
                                ranking[j] = ranking[j + 1];
                                ranking[j + 1] = repos;
                            }
                        }
                    }
                    Dt.Rows.Clear();
                    for (int k = 0; k < 10; k++)
                    {
                        DataRow row = Dt.NewRow();
                        row["Id"] = ranking[k].Id.ToString();
                        row["Nome"] = ranking[k].Nome.ToString();
                        row["Pontos"] = ranking[k].Pontos.ToString();
                        Dt.Rows.Add(row);
                    }
                }
                catch {}
            }
        }

        public async void ConnectFire()
        {
            dgv_Rank.Visible = false;
            client = new FireSharp.FirebaseClient(config);

            int l = 0;
            FirebaseResponse Resp2 = await client.GetAsync("Counter/node");
            Counter_Class obj1 = Resp2.ResultAs<Counter_Class>();
            cnt = Convert.ToInt32(obj1.Cnt);
            while (true)
            {
                if (l == cnt)
                    break;
                l++;
                try
                {
                    FirebaseResponse Resp3 = await client.GetAsync("Information/" + l);
                    Data Obj2 = Resp3.ResultAs<Data>();
                    ranking.Add(Obj2);
                }
                catch {}
            }

            if (client != null)
            {
                pb_Loading.Visible = false;
                Export();
            }
           
            Dt.Columns.Add("Id");
            Dt.Columns.Add("Nome");
            Dt.Columns.Add("Pontos");

            dgv_Rank.DataSource = Dt;
        }
        
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu.Show();
            menu.paused = false;
            this.Close();
        }
    }
}
