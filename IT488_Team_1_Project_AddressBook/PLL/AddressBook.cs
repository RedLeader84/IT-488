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
        public int selectedId = -1;
        public string selectedName = "";

        public AddressBook()
        {
            InitializeComponent();
        }

        private void AddressBook_Load(object sender, EventArgs e)
        {
            contactViewer.DataSource = Connection.Load_DataGrid();
            contactViewer.Columns["ID"].Visible = false;
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
            f = new AddEditContact(b.Text, selectedId);
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
                selectedId = Convert.ToInt32(row.Cells["ID"].Value);
                selectedName = row.Cells["Name"].Value.ToString();
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
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure you want to delete " + selectedName + " from contact list?", "Delete Contact", buttons);

            if (result == DialogResult.Yes)
            {
/*                int otherId = -1;
                int addressId = -1;

                //Remove associated record from contactOther table.
                foreach (projectDataSet.contactOtherRow r in Connection.dbDataSet.contactOther)
                {
                    if (r.contactId == selectedId)
                        otherId = r.id;
                }

                //Remove associated record from contactAddress table.
                foreach (projectDataSet.contactAddressRow r in Connection.dbDataSet.contactAddress)
                {
                    if (r.contactId == selectedId)
                        addressId = r.id;
                }
*/
                //Remove Rows From Tables.
                Connection.dbDataSet.contactOther.Rows[selectedId].Delete();
                Connection.dbDataSet.contactAddress.Rows[selectedId].Delete();
                Connection.dbDataSet.contactName.Rows[selectedId].Delete();
                Connection.dbDataSet.AcceptChanges();
            }

            contactViewer.DataSource = Connection.Load_DataGrid();
            if (firstNameRadio.Checked)
                contactViewer.Sort(contactViewer.Columns["FirstName"], System.ComponentModel.ListSortDirection.Ascending);
            if (lastNameRadio.Checked)
                contactViewer.Sort(contactViewer.Columns["LastName"], System.ComponentModel.ListSortDirection.Ascending);
        }
    }
}
