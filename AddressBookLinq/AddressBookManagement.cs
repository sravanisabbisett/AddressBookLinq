using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AddressBookLinq
{
    class AddressBookManagement
    {
        //uc1 creating DataTable
        DataTable dataTable = new DataTable();
        public AddressBookManagement()
        {
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("State", typeof(string));
            dataTable.Columns.Add("Zip", typeof(string));
            dataTable.Columns.Add("PhoneNumber", typeof(string));
            dataTable.Columns.Add("EmailId", typeof(string));

            dataTable.Rows.Add("Sravani", "Sabbisetti", "GandhiChowk", "Bantumilli", "AndhraPradesh", "521324", "8712443377", "Sravani@gmail.com");
            dataTable.Rows.Add("Akhilesh", "Sabbisetti", "Perungudi", "Chennai", "Tamilnadu", "456789", "7207321696", "Akhilesh@gmail.com");
            dataTable.Rows.Add("Sailaja", "Sabbisetti", "VyjayanthiTraders", "Bantumilli","AndhraPradesh", "789012", "9295702642", "sailaja@gmail.com");
            dataTable.Rows.Add("Badarinath", "Sabbisetti", "Aswini", "Bantumilli", "AndhraPradesh", "521324", "9290815127", "Badarinath@gmail.com");
            dataTable.Rows.Add("Manjusha", "Chedhalla", "Ponnur", "Guntur", "AndhraPradesh", "789065", "2345678912", "Manjusha@gmail.com");
        }
    }
}
