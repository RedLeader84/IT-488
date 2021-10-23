using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace IT488_Team_1_Project_AddressBook.DAL
{
    class Connection
    {
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Larissa\Source\Repos\RedLeader84\IT-488\IT488_Team_1_Project_AddressBook\projectDB.mdf;Integrated Security=True");
    }
}
