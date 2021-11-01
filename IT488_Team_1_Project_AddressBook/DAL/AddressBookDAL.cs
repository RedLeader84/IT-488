using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using IT488_Team_1_Project_AddressBook.BLL;

namespace IT488_Team_1_Project_AddressBook.DAL
{

   public class AddressBookDAL
    {
<<<<<<< HEAD
        DataTable dt = new DataTable();
        public DataTable ReadContacts()
        {
            Connection conn = new Connection();
            if (ConnectionState.Closed == conn.con.State)
            {
                conn.con.Open();
            }
            SqlCommand cmd = new SqlCommand("select concat(firstName, ' ', lastName) as Name, phoneNum as Phone, email as Email, addressLine1 as Address, city as City, state as State, zip as Zip, comments as Comment FROM contactName INNER JOIN contactAddress on contactAddress.contactId = contactName.id INNER JOIN contactOther on contactOther.contactId = contactName.id;", conn.con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch
            {
                throw;
            }
        }
        public DataTable SearchContacts()
        {
            Connection conn = new Connection();
            if (ConnectionState.Closed == conn.con.State)
            {
                conn.con.Open();
            }
            SqlCommand cmd = new SqlCommand("select concat(firstName, ' ', lastName) as Name, phoneNum as Phone, email as Email, addressLine1 as Address, city as City, state as State, zip as Zip, comments as Comment FROM contactName INNER JOIN contactAddress on contactAddress.contactId = contactName.id INNER JOIN contactOther on contactOther.contactId = contactName.id WHERE Name like % ' + SearchContacts + '%';", conn.con);
            
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch
            {
                throw;
            }
        }
        
=======
>>>>>>> 782c7b47b07f6cfe23828a7d1eb922cf82b37f0b
    }
}
