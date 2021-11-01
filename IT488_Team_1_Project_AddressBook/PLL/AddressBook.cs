using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IT488_Team_1_Project_AddressBook.BLL;

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

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddressBookBLL objBLL = new AddressBookBLL();
            dataGridView1.DataSource = objBLL.GetContacts();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddressBookBLL objBLL = new AddressBookBLL();
            dataGridView1.DataSource = objBLL.SearchContacts();
        }
    }
}
