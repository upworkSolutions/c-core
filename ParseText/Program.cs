using System;

namespace ParseText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "John.Davidson/Berlin Michael.Barton/Lisbon Ivan.Perkinson/Moscow";
            string[] names = text.Split('.', '/', ' ');

            // Split based on the space to get a complete record
            string[] personDetails = text.Split(" ");
            // Iterate through a complete record and split first name, last name and City
            Person[] persons = new Person[personDetails.Length];
            for (int i  =0; i<personDetails.Length;i++)
            {
                string[] individualPerson = personDetails[i].Split('.','/');
                Person p = new Person() { 
                    FirstName = individualPerson[0],
                    LastName = individualPerson[1],
                    City = individualPerson[2],
                };
                persons[i] = p;
            }

            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine(persons[i].FirstName + " " + persons[i].LastName + " " + persons[i].City);
            }

        }
    }

    internal class Person { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}

