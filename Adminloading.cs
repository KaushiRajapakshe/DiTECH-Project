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
    public partial class Adminloading : Form
    {
        bool flag;
        public Adminloading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 99)
            {
                if (flag)
                {
                    flag = false;
                    lblLoading.Text = "Loading..";
                }
                else
                {
                    flag = true;
                    lblLoading.Text = "Loading...";
                }

                progressBar1.Value += 10;
                if (progressBar1.Value > 90)
                {
                    timer2.Enabled = true;
                    timer2.Start();
                }
            }
            else
            {
                timer1.Stop();
                timer1.Enabled = false;
            }
        }

        private void Adminloading_Load(object sender, EventArgs e)
        {
            flag = true;
            timer1.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.025;

            if (this.Opacity <= 0)
            {
                timer2.Enabled = false;
                this.Visible = false;
                new Administrator_Log_In().Show();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
