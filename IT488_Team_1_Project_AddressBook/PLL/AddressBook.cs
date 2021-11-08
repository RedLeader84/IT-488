using IT488_Team_1_Project_AddressBook.DAL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace IT488_Team_1_Project_AddressBook.PLL
{
    public partial class AddressBook : Form
    {
        public AddressBook()
        {
            InitializeComponent();
        }

        private void AddressBook_Load(object sender, EventArgs e)
        {
            contactViewer.DataSource = Connection.Load_DataGrid();

            //Adjust Window Size To DataTable
            this.Size = new Size(contactViewer.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + 75, 500);
            this.CenterToScreen();
        }

        private void addEditButton_Click(object sender, EventArgs e)
        {
            Form f = new AddEditContact();
            f.ShowDialog();
        }
    }
}
