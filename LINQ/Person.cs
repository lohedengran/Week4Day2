using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace LINQ
{
    class Person : IEqualityComparer<Person>
    {
        public string Name { get; set; }
        public DateTime NameDay { get; set; }

        public Person(string name, DateTime nameDay)
        {
            Name = name;
            NameDay = nameDay;
        }
        public override string ToString()
        {
            return $"{Name} {NameDay}";
        }

        public bool Equals([AllowNull] Person x, [AllowNull] Person y)
        {
            return x.Name == y.Name;
        }

        public int GetHashCode([DisallowNull] Person obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}
