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
    public partial class Book_Issue : Form
    {
        public Book_Issue()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            
        }

        private void btnissue_Click(object sender, EventArgs e)
        {
            int mid = Convert.ToInt32(txtmemberid.Text);
            int bid = Convert.ToInt32(txtbookid.Text);
            BookTransactionBl btbl = new BookTransactionBl();
            string message = btbl.IssueBook(bid, mid);
            MessageBox.Show(message);
        }
    }
}
