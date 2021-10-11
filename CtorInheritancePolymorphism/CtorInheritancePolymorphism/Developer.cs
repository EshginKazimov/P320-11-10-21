using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    //Yalniz bir class-dan miras alinir - inheritance
    class Developer : Person
    {
        public string Stack;

        public Developer(string name, string surname, int age, string stack) : base(name, surname, age)
        {
            Stack = stack;
        }

        public override string GetFullName()
        {
            //return $"{Name} {Surname} {Age} {Stack}";
            //return $"{Stack}";
            return $"{base.GetFullName()} {Stack}";
        }
    }
}
