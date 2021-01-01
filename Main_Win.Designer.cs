namespace Leo_Library_Management_System
{
    partial class Main_Win
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Win));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Newbook = new System.Windows.Forms.Label();
            this.Adduser = new System.Windows.Forms.Label();
            this.Fine = new System.Windows.Forms.Label();
            this.btnNewbook = new System.Windows.Forms.Button();
            this.btnAdduser = new System.Windows.Forms.Button();
            this.btnFine = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(101, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 77);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Newbook
            // 
            this.Newbook.AutoSize = true;
            this.Newbook.BackColor = System.Drawing.Color.Transparent;
            this.Newbook.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Newbook.ForeColor = System.Drawing.Color.Lavender;
            this.Newbook.Image = ((System.Drawing.Image)(resources.GetObject("Newbook.Image")));
            this.Newbook.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Newbook.Location = new System.Drawing.Point(129, 153);
            this.Newbook.Name = "Newbook";
            this.Newbook.Size = new System.Drawing.Size(376, 33);
            this.Newbook.TabIndex = 1;
            this.Newbook.Text = "#    Add new books to the Library";
            this.Newbook.Click += new System.EventHandler(this.Newbook_Click);
            // 
            // Adduser
            // 
            this.Adduser.AutoSize = true;
            this.Adduser.BackColor = System.Drawing.Color.Transparent;
            this.Adduser.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adduser.ForeColor = System.Drawing.Color.Lavender;
            this.Adduser.Image = ((System.Drawing.Image)(resources.GetObject("Adduser.Image")));
            this.Adduser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Adduser.Location = new System.Drawing.Point(184, 229);
            this.Adduser.Name = "Adduser";
            this.Adduser.Size = new System.Drawing.Size(367, 33);
            this.Adduser.TabIndex = 2;
            this.Adduser.Text = "#    Add new User to the Library";
            this.Adduser.Click += new System.EventHandler(this.Adduser_Click);
            // 
            // Fine
            // 
            this.Fine.AutoSize = true;
            this.Fine.BackColor = System.Drawing.Color.Transparent;
            this.Fine.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fine.ForeColor = System.Drawing.Color.Lavender;
            this.Fine.Image = ((System.Drawing.Image)(resources.GetObject("Fine.Image")));
            this.Fine.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Fine.Location = new System.Drawing.Point(238, 309);
            this.Fine.Name = "Fine";
            this.Fine.Size = new System.Drawing.Size(344, 33);
            this.Fine.TabIndex = 3;
            this.Fine.Text = "#    Verify User Fine on Books";
            this.Fine.Click += new System.EventHandler(this.Fine_Click);
            // 
            // btnNewbook
            // 
            this.btnNewbook.BackColor = System.Drawing.Color.White;
            this.btnNewbook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewbook.BackgroundImage")));
            this.btnNewbook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewbook.ForeColor = System.Drawing.Color.White;
            this.btnNewbook.Location = new System.Drawing.Point(50, 131);
            this.btnNewbook.Name = "btnNewbook";
            this.btnNewbook.Size = new System.Drawing.Size(59, 64);
            this.btnNewbook.TabIndex = 4;
            this.btnNewbook.UseVisualStyleBackColor = false;
            this.btnNewbook.Click += new System.EventHandler(this.btnNewbook_Click);
            // 
            // btnAdduser
            // 
            this.btnAdduser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdduser.BackgroundImage")));
            this.btnAdduser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdduser.Location = new System.Drawing.Point(101, 212);
            this.btnAdduser.Name = "btnAdduser";
            this.btnAdduser.Size = new System.Drawing.Size(62, 60);
            this.btnAdduser.TabIndex = 5;
            this.btnAdduser.UseVisualStyleBackColor = true;
            // 
            // btnFine
            // 
            this.btnFine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFine.BackgroundImage")));
            this.btnFine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFine.Location = new System.Drawing.Point(154, 292);
            this.btnFine.Name = "btnFine";
            this.btnFine.Size = new System.Drawing.Size(57, 60);
            this.btnFine.TabIndex = 6;
            this.btnFine.UseVisualStyleBackColor = true;
            this.btnFine.Click += new System.EventHandler(this.btnFine_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(666, 411);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 38);
            this.btnExit.TabIndex = 7;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(12, 411);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(59, 38);
            this.btnBack.TabIndex = 8;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // Main_Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFine);
            this.Controls.Add(this.btnAdduser);
            this.Controls.Add(this.btnNewbook);
            this.Controls.Add(this.Fine);
            this.Controls.Add(this.Adduser);
            this.Controls.Add(this.Newbook);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Main_Win";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Main Window";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Newbook;
        private System.Windows.Forms.Label Adduser;
        private System.Windows.Forms.Label Fine;
        private System.Windows.Forms.Button btnNewbook;
        private System.Windows.Forms.Button btnAdduser;
        private System.Windows.Forms.Button btnFine;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Timer timer4;
    }
}