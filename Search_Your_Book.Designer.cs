namespace Leo_Library_Management_System
{
    partial class Search_Your_Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Your_Book));
            this.lblSearchkeywrd = new System.Windows.Forms.Label();
            this.lblAuname = new System.Windows.Forms.Label();
            this.lblPubook = new System.Windows.Forms.Label();
            this.txtSearchkeywrd = new System.Windows.Forms.TextBox();
            this.txtAuname = new System.Windows.Forms.TextBox();
            this.txtPubook = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchkeywrd
            // 
            this.lblSearchkeywrd.AutoSize = true;
            this.lblSearchkeywrd.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchkeywrd.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchkeywrd.ForeColor = System.Drawing.Color.White;
            this.lblSearchkeywrd.Location = new System.Drawing.Point(61, 44);
            this.lblSearchkeywrd.Name = "lblSearchkeywrd";
            this.lblSearchkeywrd.Size = new System.Drawing.Size(173, 26);
            this.lblSearchkeywrd.TabIndex = 0;
            this.lblSearchkeywrd.Text = "Searching Keywords";
            // 
            // lblAuname
            // 
            this.lblAuname.AutoSize = true;
            this.lblAuname.BackColor = System.Drawing.Color.Transparent;
            this.lblAuname.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuname.ForeColor = System.Drawing.Color.White;
            this.lblAuname.Location = new System.Drawing.Point(61, 90);
            this.lblAuname.Name = "lblAuname";
            this.lblAuname.Size = new System.Drawing.Size(131, 26);
            this.lblAuname.TabIndex = 1;
            this.lblAuname.Text = "Author\'s Name";
            // 
            // lblPubook
            // 
            this.lblPubook.AutoSize = true;
            this.lblPubook.BackColor = System.Drawing.Color.Transparent;
            this.lblPubook.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPubook.ForeColor = System.Drawing.Color.White;
            this.lblPubook.Location = new System.Drawing.Point(61, 140);
            this.lblPubook.Name = "lblPubook";
            this.lblPubook.Size = new System.Drawing.Size(154, 26);
            this.lblPubook.TabIndex = 2;
            this.lblPubook.Text = "Publisher of Book";
            // 
            // txtSearchkeywrd
            // 
            this.txtSearchkeywrd.Location = new System.Drawing.Point(274, 49);
            this.txtSearchkeywrd.Name = "txtSearchkeywrd";
            this.txtSearchkeywrd.Size = new System.Drawing.Size(256, 20);
            this.txtSearchkeywrd.TabIndex = 3;
            // 
            // txtAuname
            // 
            this.txtAuname.Location = new System.Drawing.Point(274, 95);
            this.txtAuname.Name = "txtAuname";
            this.txtAuname.Size = new System.Drawing.Size(256, 20);
            this.txtAuname.TabIndex = 4;
            // 
            // txtPubook
            // 
            this.txtPubook.Location = new System.Drawing.Point(274, 145);
            this.txtPubook.Name = "txtPubook";
            this.txtPubook.Size = new System.Drawing.Size(256, 20);
            this.txtPubook.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 182);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Honeydew;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Location = new System.Drawing.Point(329, 404);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 47);
            this.btnClear.TabIndex = 8;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Honeydew;
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Location = new System.Drawing.Point(420, 404);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(64, 47);
            this.btnHome.TabIndex = 9;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(508, 404);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 46);
            this.btnExit.TabIndex = 10;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Search_Your_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPubook);
            this.Controls.Add(this.txtAuname);
            this.Controls.Add(this.txtSearchkeywrd);
            this.Controls.Add(this.lblPubook);
            this.Controls.Add(this.lblAuname);
            this.Controls.Add(this.lblSearchkeywrd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Search_Your_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Your Books Here";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchkeywrd;
        private System.Windows.Forms.Label lblAuname;
        private System.Windows.Forms.Label lblPubook;
        private System.Windows.Forms.TextBox txtSearchkeywrd;
        private System.Windows.Forms.TextBox txtAuname;
        private System.Windows.Forms.TextBox txtPubook;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timer1;
    }
}