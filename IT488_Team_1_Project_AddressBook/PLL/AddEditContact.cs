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
            if (!firstNameTextBox.Text.All(c => Char.IsLetter(c)))
            {
                firstNameLabel.ForeColor = Color.Red;
                errors = true;
            }
            else firstNameLabel.ForeColor = Color.Black;
            if (!lastNameTextBox.Text.All(c => Char.IsLetter(c)))
            {
                lastNameLabel.ForeColor = Color.Red;
                errors = true;
            }
            else lastNameLabel.ForeColor = Color.Black;
            if (!cityTextBox.Text.All(c => Char.IsLetter(c)))
            {
                cityLabel.ForeColor = Color.Red;
                errors = true;
            }
            else cityLabel.ForeColor = Color.Black;
            if (!stateTextBox.Text.All(c => Char.IsLetter(c)) || stateTextBox.Text.Length > 2)
            {
                stateLabel.ForeColor = Color.Red;
                errors = true;
            }
            else stateLabel.ForeColor = Color.Black;
            if (!zipTextBox.Text.All(c => Char.IsNumber(c)) || stateTextBox.Text.Length > 5)
            {
                zipLabel.ForeColor = Color.Red;
                errors = true;
            }
            else zipLabel.ForeColor = Color.Black;

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
    }
}
