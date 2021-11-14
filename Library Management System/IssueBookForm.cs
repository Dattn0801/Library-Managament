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
    public partial class IssueBookForm : Form
    {
        public IssueBookForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-JHMQUB7\KTEAM;Initial Catalog=MyLibrary;Integrated Security=True");

        
        private void FillStudent()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select StdId from StudentTbl",Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StdId",typeof(int));
            dt.Load(rdr);
            cbStu.ValueMember = "StdId";
            cbStu.DataSource = dt;
            Con.Close();
        }
        private void FillBook()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select BookName from BookTbl where Qty > "+0+" ", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("BookName", typeof(string));
            dt.Load(rdr);
            cbBook.ValueMember = "BookName";
            cbBook.DataSource = dt;
            Con.Close();
        }
        private void fetchsdata()
        {
            Con.Open();
            string query = "select * from  StudentTbl where StdId = " + cbStu.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query,Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                stdName.Text = dr["StdName"].ToString();
                stdDep.Text = dr["StdDepartment"].ToString();
                stdPhone.Text = dr["stdPhone"].ToString();
            }
            Con.Close();
        }
        private void UpdateBook()
        {
            int Quantity,newQuantity;

            Con.Open();
            string query = "select * from  BookTbl where BookName = '" + cbBook.SelectedValue.ToString() + "' ";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Quantity = Convert.ToInt32(dr["Qty"].ToString());
                newQuantity = Quantity - 1;
                string query1 = "update BookTbl set Qty= " + newQuantity + " where BookName='" + cbBook.SelectedValue.ToString() + "';";
                SqlCommand cmd1 = new SqlCommand(query1, Con);
                cmd1.ExecuteNonQuery();
            }         
            Con.Close();  
        }
        public void populate()
        {
            Con.Open();
            string query = "select * from IssueTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvBook.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void IssueBookForm_Load(object sender, EventArgs e)
        {
            FillStudent();
            FillBook();

            populate();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.Show();
        }

        private void cbStu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchsdata();
        }

        private void cbBook_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIssue_Click(object sender, EventArgs e)
        {        
            if (issNum.Text == "" || stdName.Text == "")
            {
                MessageBox.Show("Missing Informaiton");
            }
            else
            {
                string Issuedate = dtpIssueDate.Value.Day.ToString() + "/" + dtpIssueDate.Value.Month.ToString() + "/" + dtpIssueDate.Value.Year.ToString();
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into IssueTbl values ('" + issNum.Text + "','" + cbStu.Text + "','" + stdName.Text + "','" + stdDep.Text + "','" + stdPhone.Text + "','" + cbBook.Text + "','" + Issuedate + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book  Successfully Issued");
                Con.Close();
                UpdateBook();
                populate();
            }
            
        }
    }
}
