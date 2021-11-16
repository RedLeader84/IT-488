using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IT488_Team_1_Project_AddressBook.PLL
{
    public partial class AddEditContact : Form
    {
        public AddEditContact()
        {
            InitializeComponent();
        }


        #region Button Events
        private void saveButton_Click(object sender, EventArgs e)
        {
            bool errors = false;

            //Data Validation
            #region Data Validation
            if (!firstNameTextBox.Text.All(c => Char.IsLetter(c)) || firstNameTextBox.Text.Length == 0)
            {
                firstNameLabel.ForeColor = Color.Red;
                errors = true;
            }
            else firstNameLabel.ForeColor = Color.Black;
            if (!lastNameTextBox.Text.All(c => Char.IsLetter(c)) || firstNameTextBox.Text.Length == 0)
            {
                lastNameLabel.ForeColor = Color.Red;
                errors = true;
            }
            else lastNameLabel.ForeColor = Color.Black;
            if (address1TextBox.Text.Length == 0)
            {
                address1Label.ForeColor = Color.Red;
                errors = true;
            }
            else address1Label.ForeColor = Color.Black;
            if (!cityTextBox.Text.All(c => Char.IsLetter(c)) || firstNameTextBox.Text.Length == 0)
            {
                cityLabel.ForeColor = Color.Red;
                errors = true;
            }
            else cityLabel.ForeColor = Color.Black;
            if (!stateTextBox.Text.All(c => Char.IsLetter(c)) || stateTextBox.Text.Length > 2 || firstNameTextBox.Text.Length == 0)
            {
                stateLabel.ForeColor = Color.Red;
                errors = true;
            }
            else stateLabel.ForeColor = Color.Black;
            if (!zipTextBox.Text.All(c => Char.IsNumber(c)) || stateTextBox.Text.Length > 5 || firstNameTextBox.Text.Length == 0)
            {
                zipLabel.ForeColor = Color.Red;
                errors = true;
            }
            else zipLabel.ForeColor = Color.Black;
            //phone number
            if (!IsValidEmail(emailTextBox.Text) || firstNameTextBox.Text.Length == 0)
            {
                emailLabel.ForeColor = Color.Red;
                errors = true;
            }
            else emailLabel.ForeColor = Color.Black;
            //Comments box does not require validation.
            #endregion

            //Check for errors and display message dialog.
            if (errors)
            {
                MessageBox.Show("Input Errors", "Please correct input errors.");
            }
            else
            {
                this.Close();
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        private void phoneTextBox_Enter(object sender, EventArgs e)
        {
            TextBox b = sender as TextBox;

            
        }
        private void phoneTextBox_Leave(object sender, EventArgs e)
        {

        }

        //Data Validation Functions
        private bool IsValidEmail(string e)
        {
            bool result = false;

            try
            {
                var validator = new System.Net.Mail.MailAddress(e);
                result = (e.LastIndexOf(".") > e.LastIndexOf("@"));
            }
            catch
            {
                result = false;
            }

            return result;
        }
    }
}
