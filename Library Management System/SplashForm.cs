using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        int startPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 2;
            bunifuProgressBar1.Value = startPoint;
            Percentage.Text = "" + startPoint;
            if(bunifuProgressBar1.Value == 100)
            {

                timer1.Stop();
                LoginForm log = new LoginForm();
                log.Show();
                this.Hide();
            }
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

    }
}
