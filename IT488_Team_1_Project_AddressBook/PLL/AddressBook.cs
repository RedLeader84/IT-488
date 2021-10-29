using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IT488_Team_1_Project_AddressBook.BLL;
using IT488_Team_1_Project_AddressBook.DAL;

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
            dataGridView1.DataSource = Connection.Load_DataGrid();

            //Adjust Window Size To DataTable
            this.Size = new Size(dataGridView1.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + 75, 500);
            this.CenterToScreen();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
