using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = ImportToList();
           
            

        }

        private static List<Person> ImportToList()
        {
            List<Person> contacts = new List<Person>();
            
            var contentOfFile = File
                .ReadLines("names.csv")
                .ToList();

            foreach (var item in contentOfFile)
            {
                var data = item.Split(';');
                string name = data[0];
                DateTime nameDay = DateTime.Parse(data[1]);
                Person p = new Person(name, nameDay);

                var exist = contacts
                    .Contains(p, p);

                if (!exist)
                    contacts.Add(p);

            }
            return contacts;
          
        }
    }
}
