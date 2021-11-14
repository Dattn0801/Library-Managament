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
    public partial class BookTbl : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-JHMQUB7\KTEAM;Initial Catalog=MyLibrary;Integrated Security=True");
        public BookTbl()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {  
            this.Hide();
            MainForm mf = new MainForm();
            mf.Show();
        }

        private void BookTbl_Load(object sender, EventArgs e)
        {
            populate();
        }
        public void populate()
        {
            Con.Open();
            string query = "select * from BookTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvBook.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (tbBookName.Text == "" || tbAuthor.Text == "" || tbPublisher.Text == "" || tbPrice.Text == "" || tbQuantity.Text =="")
            {
                MessageBox.Show("Missing Informaiton");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into BookTbl values ('" + tbBookName.Text + "','" + tbAuthor.Text + "','" + tbPublisher.Text + "','" + tbPrice.Text + "','"+tbQuantity.Text+"')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Add Successfully");
                Con.Close();
                populate();
            }
        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbBookName.Text = dgvBook.SelectedRows[0].Cells[0].Value.ToString();
            tbAuthor.Text = dgvBook.SelectedRows[0].Cells[1].Value.ToString();
            tbPublisher.Text = dgvBook.SelectedRows[0].Cells[2].Value.ToString();
            tbPrice.Text = dgvBook.SelectedRows[0].Cells[3].Value.ToString();
            tbQuantity.Text = dgvBook.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (tbBookName.Text == "")
            {
                MessageBox.Show("Enter the BookName id");
            }
            else
            {
                Con.Open();
                string query = "delete from BookTbl where BookName = '" + tbBookName.Text + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (tbBookName.Text == "" || tbAuthor.Text == "" || tbPublisher.Text == "" || tbPrice.Text == "" || tbQuantity.Text == "")

            {
                MessageBox.Show("Missing Informaiton");
            }
            else
            {
                Con.Open();
                string query = "update BookTbl set Author='" + tbAuthor.Text + "',Publisher='" + tbPublisher.Text + "',Price='" + tbPrice.Text + "', Qty='" + tbQuantity.Text + "'  where BookName= '" + tbBookName.Text + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Edit Book Successfully");
                Con.Close();
                populate();
            }
        }
    }
}
