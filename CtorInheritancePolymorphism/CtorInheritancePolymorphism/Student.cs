using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Student
    {
        public string Name;
        public string Surname;
        public int Age;
        public string Group;

        //Return type yoxdur
        //Class-la eyni ad olmalidi
        //Yalniz obyekt yaradilanda istifade olunur
        public Student()
        {
            //Console.WriteLine("Student created");
        }

        public Student(string name, string surname) : this()
        {
            Name = name;
            Surname = surname;
        }

        public Student(string name, string surname, int age) : this(name, surname)
        {
            //this.Name = Name;
            //Name = name;
            //Surname = surname;
            Age = age;
        }

        public Student(string name, string surname, int age, string group) : this(name, surname, age)
        {
            Group = group;
        }

        public string GetFullName2()
        {
            return $"{Name} {Surname}";
        }

        public string GetFullName()
        {
            if (Age > 0)
                return Name + " " + Surname + " " + Age + " " + Group;

            return Name + " " + Surname + " " + Group;
        }
    }
}
