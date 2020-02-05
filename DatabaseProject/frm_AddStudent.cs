using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class frm_AddStudent : Form
    {
        public frm_AddStudent()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txt_FirstName.Text == "")
            {
                MessageBox.Show("Please Enter First Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_LastName.Text == "")
            {
                MessageBox.Show("Please Enter Last Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Course1.Text == "")
            {
                MessageBox.Show("Please Enter Course 1 Marks", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Course2.Text == "")
            {
                MessageBox.Show("Please Enter Course 2 Marks", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Course3.Text == "")
            {
                MessageBox.Show("Please Enter Course 3 Marks", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txt_Course4.Text == "")
            {
                MessageBox.Show("Please Enter Course 4 Marks", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Course5.Text == "")
            {
                MessageBox.Show("Please Enter Course 5 Marks", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Course6.Text == "")
            {
                MessageBox.Show("Please Enter Course 6 Marks", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Course7.Text == "")
            {
                MessageBox.Show("Please Enter Course 7 Marks", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Course8.Text == "")
            {
                MessageBox.Show("Please Enter Course 8 Marks", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Course9.Text == "")
            {
                MessageBox.Show("Please Enter Course 9 Marks", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Course10.Text == "")
            {
                MessageBox.Show("Please Enter Course 10 Marks", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}