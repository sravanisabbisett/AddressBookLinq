using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AddressBookLinq
{
    class AddressBookManagement
    {
        //UC1 creating DataTable
        DataTable dataTable = new DataTable();
        public AddressBookManagement()
        {
            //UC2 Add columns
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("State", typeof(string));
            dataTable.Columns.Add("Zip", typeof(string));
            dataTable.Columns.Add("PhoneNumber", typeof(string));
            dataTable.Columns.Add("EmailId", typeof(string));

            //UC3 insert values in table
            dataTable.Rows.Add("Sravani", "Sabbisetti", "GandhiChowk", "Bantumilli", "AndhraPradesh", "521324", "8712443377", "Sravani@gmail.com");
            dataTable.Rows.Add("Akhilesh", "Sabbisetti", "Perungudi", "Chennai", "Tamilnadu", "456789", "7207321696", "Akhilesh@gmail.com");
            dataTable.Rows.Add("Sailaja", "Sabbisetti", "VyjayanthiTraders", "Bantumilli","AndhraPradesh", "789012", "9295702642", "sailaja@gmail.com");
            dataTable.Rows.Add("Badarinath", "Sabbisetti", "Aswini", "Bantumilli", "AndhraPradesh", "521324", "9290815127", "Badarinath@gmail.com");
            dataTable.Rows.Add("Manjusha", "Chedhalla", "Ponnur", "Guntur", "AndhraPradesh", "789065", "2345678912", "Manjusha@gmail.com");
        }

        /// <summary>
        /// Updates the contact.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="newValue">The new value.</param>
        /// <param name="columnName">Name of the column.</param>
        public void UpdateContact(string firstName,string lastName,string columnName,string newValue)
        {
            DataRow updateContact = dataTable.Select("FirstName = '" + firstName + "' and LastName = '" + lastName + "'").FirstOrDefault();
            updateContact[columnName] = newValue;
            Console.WriteLine("Contact is updated");
        }

        /// <summary>
        /// Deletes the contact.
        /// </summary>
        /// <param name="firstname">The firstname.</param>
        public void DeleteContact(string firstname)
        {
            var query = dataTable.AsEnumerable().Where(r => r.Field<string>("FirstName") == firstname);
            foreach(var data in query.ToList())
            {
                data.Delete();
            }
        }

        /// <summary>
        /// Retrives the state of the city or.
        /// </summary>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        public void RetriveCityOrState(string city,string state)
        {
            var query = from records in dataTable.AsEnumerable()
                        where records.Field<string>("City").Equals(city) || records.Field<string>("State").Equals(state)
                        select records;
            foreach(DataRow dataRow in query)
            {
                Console.WriteLine("\n");
                Console.WriteLine("FirstName:- " + dataRow.Field<string>("FirstName"));
                Console.WriteLine("lastName:- " + dataRow.Field<string>("LastName"));
                Console.WriteLine("Address:- " + dataRow.Field<string>("Address"));
                Console.WriteLine("City:- " + dataRow.Field<string>("City"));
                Console.WriteLine("State:- " + dataRow.Field<string>("State"));
                Console.WriteLine("zip:- " + dataRow.Field<string>("Zip"));
                Console.WriteLine("phoneNumber:- " + dataRow.Field<string>("PhoneNumber"));
                Console.WriteLine("EMail:- " + dataRow.Field<string>("EmailId"));
            }
        }

        /// <summary>
        /// Counts the state of the by city and.
        /// </summary>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        public void CountByCityAndState(string city,string state)
        {
            var query = from person in dataTable.AsEnumerable()
                        where person.Field<string>("City").Equals(city) && person.Field<string>("State").Equals(state)
                        select person;
            Console.WriteLine("No of Persons in particular city and state is:" + query.Count());
        }

        /// <summary>
        /// Orders the first name of the by.
        /// </summary>
        /// <param name="city">The city.</param>
        public void OrderByFirstName(string city)
        {
            var query = from person in dataTable.AsEnumerable()
                        where person.Field<string>("City").Equals(city)
                        orderby person.Field<string>("FirstName")
                        select person;
            foreach (DataRow dataRow in query)
            {
                Console.WriteLine("\n");
                Console.WriteLine("FirstName:- " + dataRow.Field<string>("FirstName"));
                Console.WriteLine("lastName:- " + dataRow.Field<string>("LastName"));
                Console.WriteLine("Address:- " + dataRow.Field<string>("Address"));
                Console.WriteLine("City:- " + dataRow.Field<string>("City"));
                Console.WriteLine("State:- " + dataRow.Field<string>("State"));
                Console.WriteLine("zip:- " + dataRow.Field<string>("Zip"));
                Console.WriteLine("phoneNumber:- " + dataRow.Field<string>("PhoneNumber"));
                Console.WriteLine("EMail:- " + dataRow.Field<string>("EmailId"));
            }
        }
        /// <summary>
        /// Gets all contacts.
        /// </summary>
        public void GetAllContacts()
        {
            foreach (DataRow dr in dataTable.AsEnumerable())
            {
                Console.WriteLine("\n");
                Console.WriteLine("FirstName:- " + dr.Field<string>("FirstName"));
                Console.WriteLine("lastName:- " + dr.Field<string>("LastName"));
                Console.WriteLine("Address:- " + dr.Field<string>("Address"));
                Console.WriteLine("City:- " + dr.Field<string>("City"));
                Console.WriteLine("State:- " + dr.Field<string>("State"));
                Console.WriteLine("zip:- " + dr.Field<string>("Zip"));
                Console.WriteLine("phoneNumber:- " + dr.Field<string>("PhoneNumber"));
                Console.WriteLine("EMail:- " + dr.Field<string>("EmailId"));
            }

        }
    }
}
