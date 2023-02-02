using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Inheritance.Problem_2
{
    internal class Animal
    {
        private string name;

        public string Name { get => name; set => name=value; }

        public Animal()
        {
        }

        public Animal(string name)
        {
            Name=name;
        }

        public override string? ToString()
        {
            return $"Animal's name: {Name}";
        }
    }
}
