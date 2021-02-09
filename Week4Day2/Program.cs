using System;
using System.Collections.Generic;
using System.Linq;

namespace Week4Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            people.Add(new Person("Gustav", "Vasa", 1496));
            people.Add(new Person("Fredrika ", "Bremer", 1801));
            people.Add(new Person("Jane", "Doe", 1967));
            people.Add(new Person("Kenneth", "Johansson", 2009));
            people.Add(new Person("Alfred", "Nobel", 1833));
            people.Add(new Person("Inga-Britt", "Ahlenius", 1939));
            people.Add(new Person("August", "Strindberg", 1849));
            people.Add(new Person("Elin", "Wägner", 1882));
            people.Add(new Person("Nathalie", "Johansson", 2006));
            people.Add(new Person("Ingmar", "Bergman", 1918));
            people.Add(new Person("Eva", "Ekeblad", 1724));
            people.Add(new Person("Lars", "Norén", 1944));
            people.Add(new Person("John", "Doe", 1957));
            people.Add(new Person("Ellen", "Key", 1849));
            people.Add(new Person("Håkan", "Johansson", 1962));
            people.Add(new Person("Pontus", "Wittenmark", 1979));
            people.Add(new Person("Hanna E", "Andersson", 1991));
            people.Add(new Person("Sissel", "Gade", 1992));
            people.Add(new Person("Patrik", "Jönsson", 1976));
            people.Add(new Person("Karin", "Cula", 1957));
            people.Add(new Person("Marilyn", "Johansson", 1976));
            people.Add(new Person("Kalle", "Cula", 1957));

            //var q = people
            //    .FirstOrDefault(p => p.BirthYear == 1957);
            //if (q != null)
            //    Console.WriteLine(q);
            //else
            //    Console.WriteLine("No matches");

            //var q = people
            //    .Select(p => new { AnyName = p.FirstName, AnyYear = p.BirthYear })
            //    .ToList();

            //foreach (var item in q)
            //{
            //    Console.WriteLine(item.AnyName);
            //}

            //var q = people
            //    .SingleOrDefault(p => p.LastName == "Johansson");
            //Console.WriteLine(q);

            var groups = people
                .GroupBy(p => p.FirstName);

            foreach (var group in groups)
            {
                Console.WriteLine(group.Count());
                foreach (var person in group)
                {
                    Console.WriteLine($"\t{person.FirstName}");
                }
            }
         
        }
    }
}
