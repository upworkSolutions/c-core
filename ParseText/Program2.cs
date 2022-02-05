using System;

namespace StringParsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "John.Davidson/Berlin Michael.Barton/Lisbon Ivan.Perkinson/Moscow";

            // split words by space char
            string[] words=text.Split(' ');

            // declare a persons array with word sizes
            Person[] persons=new Person[words.Length];
            
            // loop through the words and parse for name,surname and city
            for(int i=0;i<words.Length;i++)
            {
                string[] personAndCity=words[i].Split('/');
                string[] nameAndSurName=personAndCity[0].Split('.');
                
                // create person object 
                Person person=new Person
                {
                    Name=nameAndSurName[0],
                    SurName=nameAndSurName[1],
                    City=personAndCity[1]
                };

                //add into array
                persons[i]=person;
            }

            // show name on console
            foreach (var item in persons)
            {
                Console.WriteLine($"{item.Name} {item.SurName} {item.City}");
            }
            Console.ReadLine();
        }
    }

    // Person class 
    public class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string City { get; set; }
    }
}
