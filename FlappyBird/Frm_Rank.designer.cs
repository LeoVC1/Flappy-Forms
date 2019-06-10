namespace FlappyBird
{
    partial class Frm_Rank
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Rank));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dgv_Rank = new System.Windows.Forms.DataGridView();
            this.lbl_Rank = new System.Windows.Forms.Label();
            this.pb_Loading = new System.Windows.Forms.PictureBox();
            this.pShow = new System.Windows.Forms.Panel();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Gravar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Loading)).BeginInit();
            this.pShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("8BIT WONDER", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(447, 137);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("8BIT WONDER", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(447, 196);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(249, 30);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgv_Rank
            // 
            this.dgv_Rank.AllowDrop = true;
            this.dgv_Rank.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Rank.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_Rank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Rank.GridColor = System.Drawing.Color.Black;
            this.dgv_Rank.Location = new System.Drawing.Point(64, 123);
            this.dgv_Rank.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Rank.Name = "dgv_Rank";
            this.dgv_Rank.ReadOnly = true;
            this.dgv_Rank.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Rank.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("8BIT WONDER", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Rank.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dgv_Rank.RowTemplate.Height = 24;
            this.dgv_Rank.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Rank.Size = new System.Drawing.Size(336, 353);
            this.dgv_Rank.TabIndex = 7;
            // 
            // lbl_Rank
            // 
            this.lbl_Rank.AutoSize = true;
            this.lbl_Rank.Font = new System.Drawing.Font("8BIT WONDER", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rank.Location = new System.Drawing.Point(286, 25);
            this.lbl_Rank.Name = "lbl_Rank";
            this.lbl_Rank.Size = new System.Drawing.Size(216, 48);
            this.lbl_Rank.TabIndex = 10;
            this.lbl_Rank.Text = "RANK";
            // 
            // pb_Loading
            // 
            this.pb_Loading.BackColor = System.Drawing.Color.Transparent;
            this.pb_Loading.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_Loading.BackgroundImage")));
            this.pb_Loading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Loading.Image = ((System.Drawing.Image)(resources.GetObject("pb_Loading.Image")));
            this.pb_Loading.InitialImage = null;
            this.pb_Loading.Location = new System.Drawing.Point(121, 196);
            this.pb_Loading.Name = "pb_Loading";
            this.pb_Loading.Size = new System.Drawing.Size(226, 215);
            this.pb_Loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Loading.TabIndex = 12;
            this.pb_Loading.TabStop = false;
            // 
            // pShow
            // 
            this.pShow.Controls.Add(this.btn_Restart);
            this.pShow.Controls.Add(this.label2);
            this.pShow.Controls.Add(this.label1);
            this.pShow.Controls.Add(this.btn_Back);
            this.pShow.Controls.Add(this.textBox2);
            this.pShow.Controls.Add(this.textBox1);
            this.pShow.Controls.Add(this.btn_Gravar);
            this.pShow.Controls.Add(this.pb_Loading);
            this.pShow.Controls.Add(this.lbl_Rank);
            this.pShow.Controls.Add(this.dgv_Rank);
            this.pShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pShow.Location = new System.Drawing.Point(0, 0);
            this.pShow.Name = "pShow";
            this.pShow.Size = new System.Drawing.Size(766, 541);
            this.pShow.TabIndex = 30;
            // 
            // btn_Restart
            // 
            this.btn_Restart.FlatAppearance.BorderSize = 0;
            this.btn_Restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Restart.Font = new System.Drawing.Font("8BIT WONDER", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Restart.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Restart.Location = new System.Drawing.Point(447, 343);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(249, 58);
            this.btn_Restart.TabIndex = 31;
            this.btn_Restart.Text = "RESTART";
            this.btn_Restart.UseVisualStyleBackColor = true;
            this.btn_Restart.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("8BIT WONDER", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(444, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Score:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("8BIT WONDER", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name:";
            // 
            // btn_Back
            // 
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("8BIT WONDER", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Back.Location = new System.Drawing.Point(447, 418);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(249, 58);
            this.btn_Back.TabIndex = 30;
            this.btn_Back.Text = "BACK";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Gravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Gravar.FlatAppearance.BorderSize = 0;
            this.btn_Gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Gravar.Font = new System.Drawing.Font("8BIT WONDER", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gravar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Gravar.Location = new System.Drawing.Point(447, 270);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(249, 58);
            this.btn_Gravar.TabIndex = 9;
            this.btn_Gravar.Text = "Save";
            this.btn_Gravar.UseVisualStyleBackColor = false;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // Frm_Rank
            // 
            this.AccessibleName = "Frm_Rank";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(766, 541);
            this.Controls.Add(this.pShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Rank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Rank";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Loading)).EndInit();
            this.pShow.ResumeLayout(false);
            this.pShow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_Loading;
        private System.Windows.Forms.DataGridView dgv_Rank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel pShow;
        public System.Windows.Forms.Button btn_Gravar;
        public System.Windows.Forms.Button btn_Back;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Button btn_Restart;
        public System.Windows.Forms.Label lbl_Rank;
        public System.Windows.Forms.TextBox textBox1;
    }
}

