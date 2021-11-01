﻿using System.Data;
using System.Linq;

namespace IT488_Team_1_Project_AddressBook.DAL
{
        public class Connection
        {
            //Global Dataset Filled with Database
            public static projectDataSet dbDataSet = new projectDataSet();

            public static void Load_Database()
            {
                //Define Table Adapters.
                projectDataSetTableAdapters.contactNameTableAdapter nameTableAdapter = new projectDataSetTableAdapters.contactNameTableAdapter();
                projectDataSetTableAdapters.contactAddressTableAdapter addressTableAdapter = new projectDataSetTableAdapters.contactAddressTableAdapter();
                projectDataSetTableAdapters.contactOtherTableAdapter otherTableAdapter = new projectDataSetTableAdapters.contactOtherTableAdapter();

                //Fill DataSet Tables
                nameTableAdapter.Fill(dbDataSet.contactName);
                addressTableAdapter.Fill(dbDataSet.contactAddress);
                otherTableAdapter.Fill(dbDataSet.contactOther);
            }
            public static DataTable Load_DataGrid()
            {
                //LINQ query to merge datatables for viewing.
                var query = from tbl_1 in dbDataSet.contactName.AsEnumerable()
                            join tbl_2 in dbDataSet.contactAddress.AsEnumerable() on (int)tbl_1["id"] equals (int)tbl_2["contactId"]
                            join tbl_3 in dbDataSet.contactOther.AsEnumerable() on (int)tbl_1["id"] equals (int)tbl_3["contactId"]
                            select new
                            {
                                Name = tbl_1["firstName"] + " " + tbl_1["lastName"],
                                Address1 = tbl_2["addressLine1"],
                                Address2 = tbl_2["addressLine2"],
                                City = tbl_2["city"],
                                State = tbl_2["state"],
                                Zip = (int)tbl_2["zip"],
                                Phone = tbl_3["phoneNum"],
                                Email = tbl_3["email"],
                                Comments = tbl_3["comments"]
                            };

                //Save query to datatable.
                DataTable tbl = new DataTable();
                DataRow row = null;

                tbl.Columns.Add("Name");
                tbl.Columns.Add("Address1");
                tbl.Columns.Add("Address2");
                tbl.Columns.Add("City");
                tbl.Columns.Add("State");
                tbl.Columns.Add("Zip");
                tbl.Columns.Add("Phone");
                tbl.Columns.Add("Email");
                tbl.Columns.Add("Comments");

                foreach (var rowObj in query)
                {
                    row = tbl.NewRow();
                    tbl.Rows.Add(rowObj.Name, rowObj.Address1, rowObj.Address2, rowObj.City, rowObj.State, rowObj.Zip, rowObj.Phone, rowObj.Email, rowObj.Comments);
                }

                return tbl;
            }
        }
    }

