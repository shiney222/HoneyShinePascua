using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIActivity
{
    public partial class LoginPage: Form
    {
        private string mockUsername = "Honey Shine";
        private string mockPassword = "321";
        private int loginAttempts = 0;
        private const int maxAttempts = 5;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;

         
            if (username == mockUsername && password == mockPassword)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StudentForm studentForm = new StudentForm();
                studentForm.Show();  
                this.Hide();
            }
            else
            {
                loginAttempts++;
                int remainingAttempts = maxAttempts - loginAttempts;

                if (remainingAttempts > 0)
                {
                    MessageBox.Show($"Incorrect Username or Password! You have {remainingAttempts} attempts left.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Maximum login attempts reached! Click OK to reset your password.", "Locked Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    loginBtn.Enabled = false; 
                }
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
