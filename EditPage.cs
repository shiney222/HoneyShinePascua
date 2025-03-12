using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIActivity
{
    public partial class EditPage: Form
    {
        public EditPage()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTxt.Text) ||
                string.IsNullOrWhiteSpace(ageTxt.Text) ||
                string.IsNullOrWhiteSpace(addressTxt.Text) ||
                string.IsNullOrWhiteSpace(contactTxt.Text) ||
                string.IsNullOrWhiteSpace(emailTxt.Text) ||
                string.IsNullOrWhiteSpace(guardianTxt.Text) ||
                string.IsNullOrWhiteSpace(guardianContactTxt.Text) ||
                courseComboBox.SelectedIndex == -1 ||
                yearComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill out all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (!Regex.IsMatch(ageTxt.Text, @"^\d+$"))
            {
                MessageBox.Show("Age must contain only numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(contactTxt.Text, @"^\d+$") || !Regex.IsMatch(guardianContactTxt.Text, @"^\d+$"))
            {
                MessageBox.Show("Contact Numbers must contain only numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            MessageBox.Show("Details Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); 
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void ageTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
