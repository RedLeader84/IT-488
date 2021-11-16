using IT488_Team_1_Project_AddressBook.DAL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace IT488_Team_1_Project_AddressBook.PLL
{
    public partial class AddressBook : Form
    {
        //Global Form Variables
        public string selectedContact = "";

        public AddressBook()
        {
            InitializeComponent();
        }

        private void AddressBook_Load(object sender, EventArgs e)
        {
            contactViewer.DataSource = Connection.Load_DataGrid();
            contactViewer.Columns["FirstName"].Visible = false;
            contactViewer.Columns["LastName"].Visible = false;
            contactViewer.Sort(contactViewer.Columns["FirstName"], System.ComponentModel.ListSortDirection.Ascending);

            //Adjust Window Size To DataTable
            this.Size = new Size(contactViewer.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + 25, 500);
            this.CenterToScreen();
        }
        private void addEditButton_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;

            Form f = null;
            f = new AddEditContact(b.Text, selectedContact);
            f.ShowDialog();

            contactViewer.DataSource = Connection.Load_DataGrid();
            if (firstNameRadio.Checked)
                contactViewer.Sort(contactViewer.Columns["FirstName"], System.ComponentModel.ListSortDirection.Ascending);
            if (lastNameRadio.Checked)
                contactViewer.Sort(contactViewer.Columns["LastName"], System.ComponentModel.ListSortDirection.Ascending);

        }
        private void AddressBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            Connection.Update_Database();
        }
        private void contactViewer_SelectionChanged(object sender, EventArgs e)
        {
            if (contactViewer.SelectedCells.Count > 0)
            {
                DataGridViewRow row = contactViewer.Rows[contactViewer.SelectedCells[0].RowIndex];
                selectedContact = row.Cells["Name"].Value.ToString();
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "")
            {
                contactViewer.DataSource = Connection.Load_DataGrid();
                firstNameRadio.Checked = true;
                contactViewer.Sort(contactViewer.Columns["FirstName"], System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                (contactViewer.DataSource as DataTable).DefaultView.RowFilter = "Name LIKE '%" + searchTextBox.Text + "%'";
            }
        }
        private void firstNameRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
                contactViewer.Sort(contactViewer.Columns["FirstName"], System.ComponentModel.ListSortDirection.Ascending);
        }
        private void lastNameRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
                contactViewer.Sort(contactViewer.Columns["LastName"], System.ComponentModel.ListSortDirection.Ascending);
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            contactViewer.DataSource = Connection.Load_DataGrid();
            firstNameRadio.Checked = true;
            contactViewer.Sort(contactViewer.Columns["FirstName"], System.ComponentModel.ListSortDirection.Ascending);
            searchTextBox.Text = "";
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
