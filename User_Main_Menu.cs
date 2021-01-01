using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leo_Library_Management_System
{
    public partial class User_Main_Menu : Form
    {
        public User_Main_Menu()
        {
            InitializeComponent();
        }
        
        private void timer6_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;
            if (this.Opacity <= 0)
            {
                this.Visible = false;
                timer6.Enabled = false;
                new Login().Show();
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            timer6.Enabled = true;
            timer6.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;
            if (this.Opacity <= 0)
            {
                this.Visible = false;
                timer1.Enabled = false;
                new Search_Your_Book().Show();
            }
        }

        private void Searchbook_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;
            if (this.Opacity <= 0)
            {
                this.Visible = false;
                timer2.Enabled = false;
                new Issu_Your_Book().Show();
            }
        }

        private void Issuebook_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer2.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;
            if (this.Opacity <= 0)
            {
                this.Visible = false;
                timer3.Enabled = false;
                new Rules().Show();
            }
        }

        private void Rules_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;
            timer3.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;
            if (this.Opacity <= 0)
            {
                this.Visible = false;
                timer4.Enabled = false;
                new Support().Show();
            }
        }

        private void Support_Click(object sender, EventArgs e)
        {
            timer4.Enabled = true;
            timer4.Start();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;
            if (this.Opacity <= 0)
            {
                this.Visible = false;
                timer5.Enabled = false;
                new About_Library().Show();
            }
        }

        private void Aboutlibrary_Click(object sender, EventArgs e)
        {
            timer5.Enabled = true;
            timer5.Start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult Dialog = MessageBox.Show(" Are you sure you want to close the programme?", "Exit", MessageBoxButtons.YesNo);
            if (Dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (Dialog == DialogResult.No)
            {
            }
        }

        private void searchYourLibrarayBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void issuYourLibraryBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer2.Start();
        }

        private void rulesAndRegulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;
            timer3.Start();
        }

        private void helpAndSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer4.Enabled = true;
            timer4.Start();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer7.Enabled = true;
            timer7.Start();
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;
            if (this.Opacity <= 0)
            {
                this.Visible = false;
                timer7.Enabled = false;
                new About().Show();
            }
        }
    }
}
