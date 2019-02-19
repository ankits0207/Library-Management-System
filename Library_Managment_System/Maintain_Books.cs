using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Poco;

namespace Library_Managment_System_Integrated
{
    public partial class Maintain_Books : Form
    {
        public Maintain_Books()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(booknametxtbox.Text))
            {
                errorProvider9.SetError(booknametxtbox, "Please enter value");
            }
            else if (string.IsNullOrEmpty(publishertxtbox.Text))
            {
                errorProvider2.SetError(publishertxtbox, "Please enter value");
            }
            else if (string.IsNullOrEmpty(authortxtbox.Text))
            {
                errorProvider3.SetError(authortxtbox, "Please enter value");
            }
            else if (string.IsNullOrEmpty(categorytxtbox.Text))
            {
                errorProvider4.SetError(categorytxtbox, "Please enter value");
            }

            else if (string.IsNullOrEmpty(subjecttxtbox.Text))
            {
                errorProvider5.SetError(subjecttxtbox, "Please enter value");

            }

            else if (string.IsNullOrEmpty(mrptxtbox.Text))
            {
                errorProvider6.SetError(mrptxtbox, "Please enter value");

            }

            else if (string.IsNullOrEmpty(Availtxtbox.Text))
            {
                errorProvider7.SetError(Availtxtbox, "Please enter value");
            }

            else if (string.IsNullOrEmpty(counttxtbox.Text))
            {
                errorProvider8.SetError(counttxtbox, "Please enter value");
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            Book_Bl bl = new Book_Bl();
            int? id = null;
            if (string.IsNullOrEmpty(textBox1.Text) == false)
            {
                id = Convert.ToInt32(textBox1.Text);
            }


            List<Book> booklist = bl.SearchBook(id, category_box.Text, subject_box.Text, publisher_box.Text);
            dataGridView1.DataSource = booklist;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                booknametxtbox.Text = row.Cells["book_name"].Value.ToString();
                publishertxtbox.Text = row.Cells["publisher"].Value.ToString();
                authortxtbox.Text = row.Cells["author"].Value.ToString();
                categorytxtbox.Text = row.Cells["category"].Value.ToString();
                subjecttxtbox.Text = row.Cells["subject"].Value.ToString();
                mrptxtbox.Text = row.Cells["mrp"].Value.ToString();
                Availtxtbox.Text = row.Cells["availability"].Value.ToString();
                counttxtbox.Text = row.Cells["count"].Value.ToString();

            }
        }
    }
}

