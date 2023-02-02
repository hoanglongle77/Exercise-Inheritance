using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Inheritance.Problem_1
{
    internal class Child : Person
    {
        public override int Age
        {
            get => base.Age;
            set
            {
                if (value>15)
                {
                    throw new ArgumentException("Children should not be able to have an age more than 15");
                }
                else
                {
                    base.Age = value;
                }
            }
        }
        public Child(string name, int age) : base(name, age)
        {
        }
    }
}
