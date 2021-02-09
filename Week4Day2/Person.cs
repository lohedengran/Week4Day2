using System;
using System.Collections.Generic;
using System.Text;

namespace Week4Day2
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; private set; }
        public int Age => DateTime.Now.Year - BirthYear;
        public Person(string firstName, string lastName, int birthYear)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthYear = birthYear;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {BirthYear} {Age}";
        }
    }
}
