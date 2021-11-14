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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
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

        public void populate()
        {
            Con.Open();
            string query = "select * from IssueTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            btnPrint.DataSource = ds.Tables[0];
            Con.Close();
        }
        public void populateReturnBook()
        {
            Con.Open();
            string query = "select * from ReturnTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvBookReturn.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void FillBook()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select BookName from BookTbl where Qty > " + 0 + " ", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("BookName", typeof(string));
            dt.Load(rdr);
            cbBook.ValueMember = "BookName";
            cbBook.DataSource = dt;
            Con.Close();
        }
        private void UpdateBook()
        {
            int Quantity, newQuantity;

            Con.Open();
            string query = "select * from  BookTbl where BookName = '" + cbBook.SelectedValue.ToString() + "' ";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Quantity = Convert.ToInt32(dr["Qty"].ToString());
                newQuantity = Quantity + 1;
                string query1 = "update BookTbl set Qty= " + newQuantity + " where BookName='" + cbBook.SelectedValue.ToString() + "';";
                SqlCommand cmd1 = new SqlCommand(query1, Con);
                cmd1.ExecuteNonQuery();
            }
            Con.Close();
        }
        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //tbReturnNum.Text = dgvBook.SelectedRows[0].Cells[0].Value.ToString();
            cbStu.SelectedItem = btnPrint.SelectedRows[0].Cells[1].Value.ToString();
            tbStdName.Text = btnPrint.SelectedRows[0].Cells[2].Value.ToString();
            tbStdDep.Text = btnPrint.SelectedRows[0].Cells[3].Value.ToString();
            tbStdPhone.Text = btnPrint.SelectedRows[0].Cells[4].Value.ToString();
            cbBook.Text = btnPrint.SelectedRows[0].Cells[5].Value.ToString();
            dtpIssueDate.Text = btnPrint.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            populate();
            populateReturnBook();
            FillBook();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (tbIdReturn.Text == "" || cbStu.Text == "")
            {
                MessageBox.Show("Missing Informaiton");
            }
            else
            {
                string Issuedate = dtpIssueDate.Value.Day.ToString() + "/" + dtpIssueDate.Value.Month.ToString() + "/" + dtpIssueDate.Value.Year.ToString();
                string Returndate = dtpReturnDate.Value.Day.ToString() + "/" + dtpReturnDate.Value.Month.ToString() + "/" + dtpReturnDate.Value.Year.ToString();
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into ReturnTbl values ('" + tbIdReturn.Text + "','" + cbStu.Text + "','" + tbStdName.Text + "','" + tbStdDep.Text + "','" + tbStdPhone.Text + "','" + cbBook.Text + "','" + Issuedate + "','" + Returndate + "')", Con);
                cmd.ExecuteNonQuery();  
                MessageBox.Show("Book  Successfully Returned");
                Con.Close();
                UpdateBook();
                populate();
                populateReturnBook();
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {

        }
    }
}
