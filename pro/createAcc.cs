using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pro
{
    public partial class createAcc : Form
    {
        public createAcc()
        {
            InitializeComponent();
        }

        private void guna2CheckBoxShowP_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBoxShowP.Checked)
            {
                textPassword.PasswordChar = '\0';
            }
            else
            {
                textPassword.PasswordChar = '*';
            }
        }

        private void btnSingup_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textFirstName.Text))
            {
                if (!string.IsNullOrWhiteSpace(textLastName.Text))
                {
                    if (!string.IsNullOrWhiteSpace(textEmail.Text))
                    {
                        if (!string.IsNullOrWhiteSpace(textPassword.Text))
                        {
                            MessageBox.Show("Account Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form1 form1 = new Form1();
                            form1.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Please enter your password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }else
                    {
                        MessageBox.Show("Please enter your Email or Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter your last name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                }else
            {
                MessageBox.Show("Please enter your first name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }           
        }

        private void labelSignIn_Click(object sender, EventArgs e)
        {
            LabelCreateAcc login = new LabelCreateAcc();
            login.Show();
            this.Close();
        }

        private void createAcc_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
