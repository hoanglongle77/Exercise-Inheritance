using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Inheritance.Problem_2
{
    internal class Bear : Mammal
    {
        public Bear(string name) : base(name)
        {
        }

        public override string? ToString()
        {
            return $"Bear's name: {Name}";
        }
    }
}
