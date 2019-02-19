using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library_Managment_System_Integrated;

namespace Library_Management_System
{
    public partial class Book_Availability : Form
    {
        public Book_Availability()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbookname.Text) && String.IsNullOrEmpty(txtauthorname.Text) && String.IsNullOrEmpty(txtpublishername.Text))
            {
                MessageBox.Show("Please enter either book name or author name or publisher to search");
            }

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtbookname.Text = "";
            txtauthorname.Text = "";
            txtpublishername.Text = "";
        }
    }
}


