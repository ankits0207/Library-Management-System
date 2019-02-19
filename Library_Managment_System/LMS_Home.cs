using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library_Management_System;
using Poco;

namespace Library_Managment_System_Integrated
{
    public partial class LMS_Home : Form
    {
        public LMS_Home()
        {
            InitializeComponent();
           
        }

        private void maintainBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maintain_Books mb = new Maintain_Books();
            mb.Show();
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book_Issue bi = new Book_Issue();
            bi.Show();
        }

        private void memberRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member_Maintenance mm = new Member_Maintenance();
            mm.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book_Return br =new Book_Return();
            br.Show();
        }

        private void bookEnquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book_Availability ba = new Book_Availability();
            ba.Show();
        }

        
       
    }
}
