﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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

        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
