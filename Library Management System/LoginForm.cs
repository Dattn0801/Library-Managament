using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Management_System
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-JHMQUB7\KTEAM;Initial Catalog=MyLibrary;Integrated Security=True");
        
        private void btnLogin_Click(object sender, EventArgs e)
        {

            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from LibrarianTbl where LibName = '" + tbUserName.Text + "' and LibPassword='" + tbPassWord.Text + "'",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                MainForm main = new MainForm();
                main.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
            Con.Close();
        }

        private void lbClear_Click(object sender, EventArgs e)
        {
            tbUserName.Text = "";
            tbPassWord.Text = "";
        }
    }
}
