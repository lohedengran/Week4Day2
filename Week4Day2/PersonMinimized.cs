using System;
using System.Collections.Generic;
using System.Text;

namespace Week4Day2
{
    class PersonMinimized
    {
        public string Namn { get; set; }
        public int Födelseår { get; set; }

        public override string ToString()
        {
            return $"{Namn} {Födelseår}";
        }
    }
}
