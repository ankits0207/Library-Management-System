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
    public partial class Member_Maintenance : Form
    {
        List<Member> members = new List<Member>();
        public Member_Maintenance()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void Member_Maintenance_Load(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int mId;
            Int32.TryParse(txtId.Text, out mId);
            string mName = textBox1.Text;
            Member_Maintenance_Bl mmbl = new Member_Maintenance_Bl();

            if (!String.IsNullOrEmpty(txtId.Text))
            {
                if (!String.IsNullOrEmpty(mName))
                {
                    MessageBox.Show("Please don't enter name along with id");
                }
                else
                {
                    members = mmbl.findMember(mId, mName);
                }
            }
            else
            {
                if (String.IsNullOrEmpty(mName))
                    MessageBox.Show("Plese enter search criteria");
                else
                    members = mmbl.findMember(mId, mName);
            }

            dataGridViewMember.DataSource = members;
            dataGridViewMember.Refresh();
        }

        private void dataGridViewMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (true)
            {

                DataGridViewRow row = this.dataGridViewMember.Rows[e.RowIndex];
                txtName.Text = row.Cells["MemberName"].Value.ToString();
                txtCourse.Text = row.Cells["Course"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                txtContactNo.Text = row.Cells["ContactNo"].Value.ToString();
                comboBoxStatus.Text = row.Cells["Status"].Value.ToString();
            }
        }
    }
}


