using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._OOP_Part2
{
    internal class AnimalClass
    {
        private string Name = string.Empty;
        private string Breed = string.Empty;
        private uint Age;

        public AnimalClass(string name = "Bobik", string breed = "Taxa", uint age = 1)
        {
            this.Name = name;
            this.Breed = breed;
            this.Age = age;
        }
        public void Print()
        {
            Console.WriteLine($"Name: {this.Name}\nBreed: {this.Breed}\nAge: {this.Age}");
        }

        public void Voice(string voice)
        {
            Console.WriteLine($"{this.Name} says {voice}");
        }
    }
}
