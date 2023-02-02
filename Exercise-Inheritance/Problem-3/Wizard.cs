using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Inheritance.Problem_3
{
    internal class Wizard : Hero
    {
        public Wizard(string username, int level) : base(username, level)
        {
        }
    }
}
