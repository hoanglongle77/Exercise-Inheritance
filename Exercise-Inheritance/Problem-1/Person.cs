using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Inheritance.Problem_1
{
    internal class Person
    {
        private string name;
        private int age;

        public string Name { get => name; set => name=value; }

        public virtual int Age
        {
            get => age;
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("People should not be able to have a negative age");
                }
                else
                {
                    this.age = value;
                }
            }
        }

     
        public Person()
        {
        }

        public Person(string name, int age)
        {
            Name=name;
            Age=age;
        }

        public override string? ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}", this.Name, this.Age));
            return stringBuilder.ToString();
        }

    }
}
