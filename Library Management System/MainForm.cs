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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            this.Hide();
            dashBoard.Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            StudentForm student = new StudentForm();
            this.Hide();
            student.Show();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            BookTbl book = new BookTbl();
            this.Hide();
            book.Show();
        }

        private void btnLibrarians_Click(object sender, EventArgs e)
        {
            Librarians librarians = new Librarians();
            this.Hide();
            librarians.Show();
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            IssueBookForm issueBook = new IssueBookForm();
            this.Hide();
            issueBook.Show();
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook = new ReturnBook();
            this.Hide();
            returnBook.Show();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            //this.Hide();
            aboutUs.Show();
        }
    }
}
