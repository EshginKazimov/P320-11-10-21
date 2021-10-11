using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Teacher : Person
    {
        //public string Name;
        //public string Surname;
        //public int Age;
        public int Salary;

        public Teacher(string name, string surname, int age, int salary) : base(name, surname, age)
        {
            //Name = name;
            //Surname = surname;
            //Age = age;
            Salary = salary;
        }

        public override string GetFullName()
        {
            //return $"{Name} {Surname} {Age} {Salary}";
            return $"{base.GetFullName()} {Salary}";
        }
    }
}
