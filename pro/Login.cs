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
    public partial class LabelCreateAcc : Form
    {
        public LabelCreateAcc()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            string password = textPassword.Text;

            if (username == "Admin" && password == "12345678")
            {
                MessageBox.Show("Login Successful", "Success");
                this.DialogResult = DialogResult.OK; // Mark login as successful
                this.Close(); // Close login form
            }
            else
            {
                MessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {
            createAcc createAcc = new createAcc();
            createAcc.Show();
            this.Close();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
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

        private void labelSignIn_Click(object sender, EventArgs e)
        {
            createAcc createAccForm = new createAcc();
            createAccForm.Show();
            this.Hide();
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelCreateAcc_Load(object sender, EventArgs e)
        {

        }
    }
}
