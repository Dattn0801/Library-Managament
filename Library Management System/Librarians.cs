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
    public partial class Librarians : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-JHMQUB7\KTEAM;Initial Catalog=MyLibrary;Integrated Security=True");
        public Librarians()
        {
            InitializeComponent();
        }

        public void populate()
        {
            Con.Open();
            string query = "select * from LibrarianTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvLib.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.Show();
        }

        private void btnAddLib_Click(object sender, EventArgs e)
        {
            if(libID.Text == "" || libName.Text == "" || libPass.Text == "" || libPhone.Text == "" )
            {
                MessageBox.Show("Missing Informaiton");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into LibrarianTbl values (" + libID.Text + ",'" + libName.Text + "','" + libPass.Text + "','" + libPhone.Text + "')",Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Librarian Add Successfully");
                Con.Close();
                populate();
            }
        }

        private void Librarians_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnDeleteLib_Click(object sender, EventArgs e)
        {
            if(libID.Text == "")
            {
                MessageBox.Show("Enter the Librarian id");
            }
            else
            {
                Con.Open();
                string query = "delete from LibrarianTbl where LibId = " + libID.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Librarian Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void dgvLib_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            libID.Text = dgvLib.SelectedRows[0].Cells[0].Value.ToString();
            libName.Text = dgvLib.SelectedRows[0].Cells[1].Value.ToString();
            libPass.Text = dgvLib.SelectedRows[0].Cells[2].Value.ToString();
            libPhone.Text = dgvLib.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnEditLib_Click(object sender, EventArgs e)
        {
            if (libID.Text == "" || libName.Text == "" || libPass.Text == "" || libPhone.Text == "")
            {
                MessageBox.Show("Missing Informaiton");
            }
            else
            {
                Con.Open();
                string query ="update LibrarianTbl set LibName='"+libName.Text+"',LibPassword='"+libPass.Text+"',LibPhone='"+libPhone.Text+"'where LibId="+libID.Text+";";
                SqlCommand cmd = new SqlCommand(query,Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Edit Librarian Successfully");
                Con.Close();
                populate();
            }
        }
    }
}
