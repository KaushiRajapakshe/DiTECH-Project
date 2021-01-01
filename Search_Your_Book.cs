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
    public partial class Search_Your_Book : Form
    {
        public Search_Your_Book()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;
            if (this.Opacity <= 0)
            {
                this.Visible = false;
                timer1.Enabled = false;
                new User_Main_Menu().Show();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearchkeywrd.Clear();
            txtAuname.Clear();
            txtPubook.Clear();
            txtSearchkeywrd.Focus();
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
    }
}
