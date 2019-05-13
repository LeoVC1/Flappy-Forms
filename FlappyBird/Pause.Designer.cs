namespace FlappyBird
{
    partial class FrmPause
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPause));
            this.btn_Resume = new System.Windows.Forms.Button();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.lbl_PauseTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Resume
            // 
            this.btn_Resume.FlatAppearance.BorderSize = 0;
            this.btn_Resume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Resume.Location = new System.Drawing.Point(74, 101);
            this.btn_Resume.Name = "btn_Resume";
            this.btn_Resume.Size = new System.Drawing.Size(138, 47);
            this.btn_Resume.TabIndex = 0;
            this.btn_Resume.Text = "Resume";
            this.btn_Resume.UseVisualStyleBackColor = true;
            this.btn_Resume.UseWaitCursor = true;
            this.btn_Resume.Click += new System.EventHandler(this.btn_Resume_Click);
            // 
            // btn_Quit
            // 
            this.btn_Quit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Quit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Quit.BackgroundImage")));
            this.btn_Quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Quit.FlatAppearance.BorderSize = 0;
            this.btn_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Quit.Location = new System.Drawing.Point(74, 164);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(138, 47);
            this.btn_Quit.TabIndex = 1;
            this.btn_Quit.UseVisualStyleBackColor = false;
            this.btn_Quit.UseWaitCursor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // lbl_PauseTitle
            // 
            this.lbl_PauseTitle.AutoSize = true;
            this.lbl_PauseTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PauseTitle.Location = new System.Drawing.Point(76, 28);
            this.lbl_PauseTitle.Name = "lbl_PauseTitle";
            this.lbl_PauseTitle.Size = new System.Drawing.Size(148, 37);
            this.lbl_PauseTitle.TabIndex = 2;
            this.lbl_PauseTitle.Text = "PAUSED";
            // 
            // FrmPause
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(290, 237);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_PauseTitle);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.btn_Resume);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPause";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paused";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Quit;
        public System.Windows.Forms.Button btn_Resume;
        private System.Windows.Forms.Label lbl_PauseTitle;
    }
}