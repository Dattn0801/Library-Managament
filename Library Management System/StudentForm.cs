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
    public partial class StudentForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-JHMQUB7\KTEAM;Initial Catalog=MyLibrary;Integrated Security=True");
        public StudentForm()
        {
            InitializeComponent();
        }

        public void populate()
        {
            Con.Open();
            string query = "select * from StudentTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvStudent.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.Show();
        }

        private void btnAddStu_Click(object sender, EventArgs e)
        {
            if (stuID.Text == "" || stuName.Text == "" || stuDep.Text == "" || stuPhone.Text == "" || cbbSemester.Text == "")
            {
                MessageBox.Show("Missing Informaiton");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into StudentTbl values (" + stuID.Text + ",'" + stuName.Text + "','" + stuDep.Text + "','" + cbbSemester.SelectedItem.ToString() + "','" + stuPhone.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Add Successfully");
                Con.Close();
                populate();
            }
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            stuID.Text = dgvStudent.SelectedRows[0].Cells[0].Value.ToString();
            stuName.Text = dgvStudent.SelectedRows[0].Cells[1].Value.ToString();
            stuDep.Text = dgvStudent.SelectedRows[0].Cells[2].Value.ToString();
            cbbSemester.Text = dgvStudent.SelectedRows[0].Cells[3].Value.ToString();
            stuPhone.Text = dgvStudent.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
