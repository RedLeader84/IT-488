using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using IT488_Team_1_Project_AddressBook.DAL;

namespace IT488_Team_1_Project_AddressBook.BLL
{
    class AddressBookBLL
    {
        public DataTable GetContacts()
        {
            try
            {
                AddressBookDAL objdal = new AddressBookDAL();
                return objdal.ReadContacts();

            }
            catch
            {
                throw;
            }
        }

        public DataTable SearchContacts()
        {
            try
            {
                AddressBookDAL objdal = new AddressBookDAL();
                return objdal.SearchContacts();

            }
            catch
            {
                throw;
            }
        }
    }
}
