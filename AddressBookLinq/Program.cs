using System;

namespace AddressBookLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AddressBook using Linq");
            AddressBookManagement addressBookManagement = new AddressBookManagement();
            while (true)
            {
                Console.WriteLine("1)GetAllData\n" + "2)UpdatePerson\n"+"3)Delete person\n"+"4)RetriceCityOrState");

                try
                {
                    var choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            addressBookManagement.GetAllContacts();
                            break;
                        case 2:
                            Console.WriteLine("Enter your firstname,Lastname");
                            string firstname = Console.ReadLine();
                            string lastName = Console.ReadLine();
                            Console.WriteLine("EnteryourColumnName");
                            string cloumnName = Console.ReadLine();
                            Console.WriteLine("Enter the value you want to update");
                            string newValue=Console.ReadLine();
                            addressBookManagement.UpdateContact(firstname, lastName, cloumnName, newValue);
                            break;
                        case 3:
                            Console.WriteLine("Enter your firstname to delete");
                            string name = Console.ReadLine();
                            addressBookManagement.DeleteContact(name);
                            break;
                        case 4:
                            Console.WriteLine("Enter your city and state");
                            string city = Console.ReadLine();
                            string state = Console.ReadLine();
                            addressBookManagement.RetriveCityOrState(city, state);
                            break;
                        default:
                            Console.WriteLine("Please Enter correct option");
                            break;
                    }
                    Console.WriteLine("Do you want to continue(Y / N) ? ");
                    var variable = Console.ReadLine();
                    if (variable.Equals("y"))
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                catch (System.FormatException formatException)
                {
                    Console.WriteLine(formatException.Message);
                }

            }
            Console.ReadKey();
        }
    }
}

