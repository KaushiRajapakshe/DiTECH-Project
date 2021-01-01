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
    public partial class Administrator_Log_In : Form
    {
        public Administrator_Log_In()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // this.Opacity += 0.01;
            //if (this.Opacity >= 0.98)
            {
                // timer1.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;
            if (this.Opacity <= 0)
            {
                this.Visible = false;
                timer2.Enabled = false;
                new Main_Win().Show();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String UN = "Kaushi";
            String PW = "Leo1211";
            {
                {
                    if (txtAdname.Text == UN && txtPass.Text == PW)
                    {
                        timer2.Enabled = true;
                        timer2.Start();
                    }
                    else
                    {
                        MessageBox.Show("             Wrong User Name or Password !    ");
                        txtAdname.Clear();
                        txtPass.Clear();
                        txtAdname.Focus();
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAdname.Clear();
            txtPass.Clear();
            txtAdname.Focus();
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
