namespace Leo_Library_Management_System
{
    partial class Add_New_Library_Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_New_Library_Books));
            this.lblPubname = new System.Windows.Forms.Label();
            this.LblBtitle = new System.Windows.Forms.Label();
            this.lblAuname = new System.Windows.Forms.Label();
            this.lblBookisbn = new System.Windows.Forms.Label();
            this.lblCate = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBtitle = new System.Windows.Forms.TextBox();
            this.txtPubname = new System.Windows.Forms.TextBox();
            this.txtAuname = new System.Windows.Forms.TextBox();
            this.txtBookisbn = new System.Windows.Forms.TextBox();
            this.cmbCate = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblPubname
            // 
            this.lblPubname.AutoSize = true;
            this.lblPubname.BackColor = System.Drawing.Color.Transparent;
            this.lblPubname.Font = new System.Drawing.Font("Minion Pro Cond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPubname.Location = new System.Drawing.Point(57, 143);
            this.lblPubname.Name = "lblPubname";
            this.lblPubname.Size = new System.Drawing.Size(158, 29);
            this.lblPubname.TabIndex = 0;
            this.lblPubname.Text = "Publisher\'s Name";
            // 
            // LblBtitle
            // 
            this.LblBtitle.AutoSize = true;
            this.LblBtitle.BackColor = System.Drawing.Color.Transparent;
            this.LblBtitle.Font = new System.Drawing.Font("Minion Pro Cond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBtitle.Location = new System.Drawing.Point(57, 54);
            this.LblBtitle.Name = "LblBtitle";
            this.LblBtitle.Size = new System.Drawing.Size(98, 29);
            this.LblBtitle.TabIndex = 1;
            this.LblBtitle.Text = "Book Title";
            // 
            // lblAuname
            // 
            this.lblAuname.AutoSize = true;
            this.lblAuname.BackColor = System.Drawing.Color.Transparent;
            this.lblAuname.Font = new System.Drawing.Font("Minion Pro Cond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuname.Location = new System.Drawing.Point(57, 98);
            this.lblAuname.Name = "lblAuname";
            this.lblAuname.Size = new System.Drawing.Size(136, 29);
            this.lblAuname.TabIndex = 2;
            this.lblAuname.Text = "Author\'s Name";
            // 
            // lblBookisbn
            // 
            this.lblBookisbn.AutoSize = true;
            this.lblBookisbn.BackColor = System.Drawing.Color.Transparent;
            this.lblBookisbn.Font = new System.Drawing.Font("Minion Pro Cond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookisbn.Location = new System.Drawing.Point(57, 186);
            this.lblBookisbn.Name = "lblBookisbn";
            this.lblBookisbn.Size = new System.Drawing.Size(129, 29);
            this.lblBookisbn.TabIndex = 3;
            this.lblBookisbn.Text = "Book ISBN No";
            // 
            // lblCate
            // 
            this.lblCate.AutoSize = true;
            this.lblCate.BackColor = System.Drawing.Color.Transparent;
            this.lblCate.Font = new System.Drawing.Font("Minion Pro Cond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCate.Location = new System.Drawing.Point(57, 244);
            this.lblCate.Name = "lblCate";
            this.lblCate.Size = new System.Drawing.Size(88, 29);
            this.lblCate.TabIndex = 4;
            this.lblCate.Text = "Category";
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(323, 373);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 49);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Maroon;
            this.btnAdd.Location = new System.Drawing.Point(189, 372);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 49);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtBtitle
            // 
            this.txtBtitle.Location = new System.Drawing.Point(250, 63);
            this.txtBtitle.Name = "txtBtitle";
            this.txtBtitle.Size = new System.Drawing.Size(148, 20);
            this.txtBtitle.TabIndex = 7;
            // 
            // txtPubname
            // 
            this.txtPubname.Location = new System.Drawing.Point(250, 152);
            this.txtPubname.Name = "txtPubname";
            this.txtPubname.Size = new System.Drawing.Size(148, 20);
            this.txtPubname.TabIndex = 8;
            // 
            // txtAuname
            // 
            this.txtAuname.Location = new System.Drawing.Point(250, 107);
            this.txtAuname.Name = "txtAuname";
            this.txtAuname.Size = new System.Drawing.Size(148, 20);
            this.txtAuname.TabIndex = 9;
            // 
            // txtBookisbn
            // 
            this.txtBookisbn.Location = new System.Drawing.Point(250, 195);
            this.txtBookisbn.Name = "txtBookisbn";
            this.txtBookisbn.Size = new System.Drawing.Size(148, 20);
            this.txtBookisbn.TabIndex = 10;
            // 
            // cmbCate
            // 
            this.cmbCate.FormattingEnabled = true;
            this.cmbCate.Location = new System.Drawing.Point(250, 252);
            this.cmbCate.Name = "cmbCate";
            this.cmbCate.Size = new System.Drawing.Size(148, 21);
            this.cmbCate.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(62, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 49);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Add_New_Library_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(494, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbCate);
            this.Controls.Add(this.txtBookisbn);
            this.Controls.Add(this.txtAuname);
            this.Controls.Add(this.txtPubname);
            this.Controls.Add(this.txtBtitle);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblCate);
            this.Controls.Add(this.lblBookisbn);
            this.Controls.Add(this.lblAuname);
            this.Controls.Add(this.LblBtitle);
            this.Controls.Add(this.lblPubname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_New_Library_Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Library Books";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPubname;
        private System.Windows.Forms.Label LblBtitle;
        private System.Windows.Forms.Label lblAuname;
        private System.Windows.Forms.Label lblBookisbn;
        private System.Windows.Forms.Label lblCate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBtitle;
        private System.Windows.Forms.TextBox txtPubname;
        private System.Windows.Forms.TextBox txtAuname;
        private System.Windows.Forms.TextBox txtBookisbn;
        private System.Windows.Forms.ComboBox cmbCate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}