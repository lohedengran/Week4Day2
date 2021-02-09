using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LINQ
{
    class Program
    {
        private const string V = "2015-07-23";

        static void Main(string[] args)
        {
            var contacts = ImportToList();

            // namn som börjar med And    
            var startsWith = contacts
                .Where(p => p.Name.StartsWith("And"));
            foreach (var contact in startsWith)
            {
                Console.WriteLine(contact);
            }

            Console.WriteLine("---");

            // namnsdag 23 juli
            var nameDayJuly23 = contacts
                .Where(p => p.NameDay.Month == 7 && p.NameDay.Day == 23);

            foreach (var contact in nameDayJuly23)
            {
                Console.WriteLine(contact);
            }

            Console.WriteLine("---");

            // börjar på P & har namnsdag i april
            var p = contacts
                .Where(p => p.NameDay.Month == 4 && p.Name.StartsWith("P"));

            foreach (var item in p)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---");
            //ta emot inmatning för namn, lista alla namn som matchar
            Console.WriteLine("Input a name: ");
            string input = Console.ReadLine();

            var isNameInList = contacts
                .Where(p => p.Name == input);

            foreach (var item in isNameInList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---");
           
            //ta emot inmatning för datum, lista alla namn som matchar
            Console.WriteLine("Input number of month: ");
            int inputMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Input a date: ");
            int inputDate = int.Parse(Console.ReadLine());

            var whosNameDay = contacts
                .Where(p => p.NameDay.Month == inputMonth && p.NameDay.Day == inputDate);

            foreach (var item in whosNameDay)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---");

            var q = contacts
                .GroupBy(p => p.Name[0]);

            foreach (var group in q)
            {
                Console.WriteLine($"{group.Count()} personer har förnamn som börjar på {group.Key}");
            }

            Console.WriteLine("---");
            var monthQuery = contacts
                .OrderBy(p => p.NameDay.Month)
                .GroupBy(p => p.NameDay.Month);

            foreach (var group in monthQuery)
            {
                Console.WriteLine($"{group.Count()} personer har namnsdag i månad {group.Key}");

            }

    

        }

        private static List<Person> ImportToList()
        {
            List<Person> contacts = new List<Person>();

            var contentOfFile = File
                .ReadLines("names.csv", System.Text.Encoding.UTF7)
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
