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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-JHMQUB7\KTEAM;Initial Catalog=MyLibrary;Integrated Security=True");

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.Show();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            Con.Open();
            //Book
            SqlDataAdapter sda1 = new SqlDataAdapter("select count(*) from BookTbl", Con);
            DataTable dt = new DataTable();
            sda1.Fill(dt);
            BookTbl1.Text = dt.Rows[0][0].ToString();
            //Student
            SqlDataAdapter sda2 = new SqlDataAdapter("select count(*) from StudentTbl", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            StudentTbl.Text = dt2.Rows[0][0].ToString();
            //librarian
            SqlDataAdapter sda3 = new SqlDataAdapter("select count(*) from LibrarianTbl", Con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            LibrarianTbl.Text = dt3.Rows[0][0].ToString();
            //Issue
            SqlDataAdapter sda4 = new SqlDataAdapter("select count(*) from IssueTbl", Con);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            IssueBook.Text = dt4.Rows[0][0].ToString();
            //Return
            SqlDataAdapter sda5 = new SqlDataAdapter("select count(*) from ReturnTbl", Con);
            DataTable dt5 = new DataTable();
            sda5.Fill(dt5);
            ReturnBook.Text = dt5.Rows[0][0].ToString();

            Con.Close();
        }
    }
}
