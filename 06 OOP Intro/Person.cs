using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Intro
{
    internal class Person
    {
        private string Name { get; set; } = string.Empty;
        private string Surname { get; set; } = string.Empty;
        private ushort Age { get; set; } = 0;

        public Person(string name, string surname, ushort age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Name: {this.Name}\nSurname: {this.Surname}\nAge: {this.Age}");
        }
    }
}
