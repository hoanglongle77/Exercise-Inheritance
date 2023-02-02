using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Inheritance.Problem_3
{
    internal class Hero
    {
        private string username;
        private int level;

        public string Username { get => username; set => username=value; }
        public int Level { get => level; set => level=value; }

        public Hero()
        {
        }
        public Hero(string username, int level)
        {
            Username=username;
            Level=level;
        }

        public override string ToString()
        {
            return $"Type:{this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }
    }
}
