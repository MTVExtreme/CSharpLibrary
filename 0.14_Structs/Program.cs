using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookEntry Paul = new AddressBookEntry()
            {
                Address = "123 Coder Pl",
                City = "Westfield",
                State = "IN",
                Zip = "44056",
                FirstName = "Paul",
                LastName = "O'Conner",
                Age = 40
            };

            AddressBookEntry Mizhcel = new AddressBookEntry()
            {
                Address = "8882 Foret Ln",
                City = "Chainchest",
                State = "IN",
                Zip = "44913",
                FirstName = "Mizhcel",
                LastName = "Blokz",
                Age = 36
            };

            AddressBookEntry Darth = new AddressBookEntry()
            {
                Address = "223 DeathStar Ln",
                City = "San Fran",
                State = "CA",
                Zip = "88888",
                FirstName = "Darth",
                LastName = "Vader",
                Age = 37
            };
            AddressBookEntry Defult = new AddressBookEntry()
            {
                Address = "123 abc Ln",
                City = "New York City",
                State = "NY",
                Zip = "123456",
                FirstName = "First Name",
                LastName = "Last Name",
                Age = 35
            };

            Console.WriteLine("Enter First Name");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter Age");
            int age = Int32.Parse(Console.ReadLine());
            Defult.ChangeEntry(fName, lName, age);

            Console.WriteLine("Name: {0} {1}\nAge: {2}",Defult.FirstName, Defult.LastName, Defult.Age);
            Console.ReadLine();
        }

        struct AddressBookEntry
        {
            public string FirstName;
            public string LastName;
            public int Age;
            public string Address;
            public string City;

            public string State;
            public string Zip;

            public string GetAddress()
            {
                return $"Address: {Address}\nCity: {City}\nState: {State}\nZip: {Zip}";
            }

            public void ChangeEntry(string firstName, string lastName, int age)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Age = age;

            }
        }


        
    }
}
