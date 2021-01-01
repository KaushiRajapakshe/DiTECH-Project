namespace Leo_Library_Management_System
{
    partial class User_Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Main_Menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Rules = new System.Windows.Forms.Label();
            this.Issuebook = new System.Windows.Forms.Label();
            this.Support = new System.Windows.Forms.Label();
            this.Searchbook = new System.Windows.Forms.Label();
            this.Aboutlibrary = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchYourLibrarayBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuYourLibraryBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesAndRegulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpAndSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(599, 85);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(135, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(524, 46);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Rules
            // 
            this.Rules.AutoSize = true;
            this.Rules.BackColor = System.Drawing.Color.Transparent;
            this.Rules.Font = new System.Drawing.Font("Adobe Hebrew", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rules.ForeColor = System.Drawing.Color.White;
            this.Rules.Location = new System.Drawing.Point(130, 277);
            this.Rules.Name = "Rules";
            this.Rules.Size = new System.Drawing.Size(269, 30);
            this.Rules.TabIndex = 2;
            this.Rules.Text = "∎    Rules and Regulation";
            this.Rules.Click += new System.EventHandler(this.Rules_Click);
            // 
            // Issuebook
            // 
            this.Issuebook.AutoSize = true;
            this.Issuebook.BackColor = System.Drawing.Color.Transparent;
            this.Issuebook.Font = new System.Drawing.Font("Adobe Hebrew", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Issuebook.ForeColor = System.Drawing.Color.White;
            this.Issuebook.Location = new System.Drawing.Point(130, 233);
            this.Issuebook.Name = "Issuebook";
            this.Issuebook.Size = new System.Drawing.Size(307, 30);
            this.Issuebook.TabIndex = 3;
            this.Issuebook.Text = "∎    Issue Your Library Books";
            this.Issuebook.Click += new System.EventHandler(this.Issuebook_Click);
            // 
            // Support
            // 
            this.Support.AutoSize = true;
            this.Support.BackColor = System.Drawing.Color.Transparent;
            this.Support.Font = new System.Drawing.Font("Adobe Hebrew", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Support.ForeColor = System.Drawing.Color.White;
            this.Support.Location = new System.Drawing.Point(130, 320);
            this.Support.Name = "Support";
            this.Support.Size = new System.Drawing.Size(233, 30);
            this.Support.TabIndex = 4;
            this.Support.Text = "∎    Help and Support";
            this.Support.Click += new System.EventHandler(this.Support_Click);
            // 
            // Searchbook
            // 
            this.Searchbook.AutoSize = true;
            this.Searchbook.BackColor = System.Drawing.Color.Transparent;
            this.Searchbook.Font = new System.Drawing.Font("Adobe Hebrew", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbook.ForeColor = System.Drawing.Color.White;
            this.Searchbook.Location = new System.Drawing.Point(130, 188);
            this.Searchbook.Name = "Searchbook";
            this.Searchbook.Size = new System.Drawing.Size(380, 30);
            this.Searchbook.TabIndex = 5;
            this.Searchbook.Text = "∎    Search Your Library Books Here";
            this.Searchbook.Click += new System.EventHandler(this.Searchbook_Click);
            // 
            // Aboutlibrary
            // 
            this.Aboutlibrary.AutoSize = true;
            this.Aboutlibrary.BackColor = System.Drawing.Color.Transparent;
            this.Aboutlibrary.Font = new System.Drawing.Font("Adobe Hebrew", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aboutlibrary.ForeColor = System.Drawing.Color.White;
            this.Aboutlibrary.Location = new System.Drawing.Point(130, 364);
            this.Aboutlibrary.Name = "Aboutlibrary";
            this.Aboutlibrary.Size = new System.Drawing.Size(235, 30);
            this.Aboutlibrary.TabIndex = 6;
            this.Aboutlibrary.Text = "∎    About the Library";
            this.Aboutlibrary.Click += new System.EventHandler(this.Aboutlibrary_Click);
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
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(654, 401);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(61, 48);
            this.btnExit.TabIndex = 7;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(12, 401);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(59, 48);
            this.btnBack.TabIndex = 8;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // timer6
            // 
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchYourLibrarayBooksToolStripMenuItem,
            this.issuYourLibraryBooksToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // searchYourLibrarayBooksToolStripMenuItem
            // 
            this.searchYourLibrarayBooksToolStripMenuItem.Name = "searchYourLibrarayBooksToolStripMenuItem";
            this.searchYourLibrarayBooksToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.searchYourLibrarayBooksToolStripMenuItem.Text = "Search Your Libraray Books";
            this.searchYourLibrarayBooksToolStripMenuItem.Click += new System.EventHandler(this.searchYourLibrarayBooksToolStripMenuItem_Click);
            // 
            // issuYourLibraryBooksToolStripMenuItem
            // 
            this.issuYourLibraryBooksToolStripMenuItem.Name = "issuYourLibraryBooksToolStripMenuItem";
            this.issuYourLibraryBooksToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.issuYourLibraryBooksToolStripMenuItem.Text = "Issue Your Library Books";
            this.issuYourLibraryBooksToolStripMenuItem.Click += new System.EventHandler(this.issuYourLibraryBooksToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rulesAndRegulationToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // rulesAndRegulationToolStripMenuItem
            // 
            this.rulesAndRegulationToolStripMenuItem.Name = "rulesAndRegulationToolStripMenuItem";
            this.rulesAndRegulationToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.rulesAndRegulationToolStripMenuItem.Text = "Rules and Regulation";
            this.rulesAndRegulationToolStripMenuItem.Click += new System.EventHandler(this.rulesAndRegulationToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpAndSupportToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpAndSupportToolStripMenuItem
            // 
            this.helpAndSupportToolStripMenuItem.Name = "helpAndSupportToolStripMenuItem";
            this.helpAndSupportToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.helpAndSupportToolStripMenuItem.Text = "Help and Support";
            this.helpAndSupportToolStripMenuItem.Click += new System.EventHandler(this.helpAndSupportToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // timer7
            // 
            this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // User_Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.Aboutlibrary);
            this.Controls.Add(this.Searchbook);
            this.Controls.Add(this.Support);
            this.Controls.Add(this.Issuebook);
            this.Controls.Add(this.Rules);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "User_Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Rules;
        private System.Windows.Forms.Label Issuebook;
        private System.Windows.Forms.Label Support;
        private System.Windows.Forms.Label Searchbook;
        private System.Windows.Forms.Label Aboutlibrary;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchYourLibrarayBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuYourLibraryBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesAndRegulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpAndSupportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Timer timer7;
    }
}