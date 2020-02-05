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
            float Course1 = 0, Course2 = 0, Course3 = 0, Course4 = 0, Course5 = 0, Course6 = 0, Course7 = 0, Course8 = 0, Course9 = 0, Course10 = 0;
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
            else if(!float.TryParse(txt_Course1.Text, out Course1))
            {
                MessageBox.Show("Please Enter Valid Course 1 Marks", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!float.TryParse(txt_Course2.Text, out Course2))
            {
                MessageBox.Show("Please Enter Valid Course 2 Marks", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!float.TryParse(txt_Course3.Text, out Course3))
            {

                MessageBox.Show("Please Enter Valid Course 3 Marks", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!float.TryParse(txt_Course4.Text, out Course4))
            {
                MessageBox.Show("Please Enter Valid Course 4 Marks", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!float.TryParse(txt_Course5.Text, out Course5))
            {
                MessageBox.Show("Please Enter Valid Course 5 Marks", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!float.TryParse(txt_Course6.Text, out Course6))
            {
                MessageBox.Show("Please Enter Valid Course 6 Marks", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!float.TryParse(txt_Course7.Text, out Course7))
            {
                MessageBox.Show("Please Enter Valid Course 7 Marks", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!float.TryParse(txt_Course8.Text, out Course8))
            {
                MessageBox.Show("Please Enter Valid Course 8 Marks", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!float.TryParse(txt_Course9.Text, out Course9))
            {
                MessageBox.Show("Please Enter Valid Course 9 Marks", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!float.TryParse(txt_Course10.Text, out Course10))
            {
                MessageBox.Show("Please Enter Valid Course 10 Marks", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}