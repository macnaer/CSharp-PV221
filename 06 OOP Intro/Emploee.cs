using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _06_OOP_Intro
{
    internal class Emploee : Person
    {
        string Position { get; set; } = string.Empty;
        readonly uint Salary;
        public Emploee(string name, string surname, ushort age, string position, uint salary) : base(name, surname,age)
        {
            this.Position = position;
            this.Salary = salary;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Position: {this.Position}\nSalary: {this.Salary}");
        }


        /// <summary>
        /// Print default CV.
        /// </summary>
        public void SaveCV()
        {
            Print();
        }

        /// <summary>
        /// Print CV with position and salary.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="salary"></param>
        public void SaveCV(string position, uint salary)
        {
            Console.WriteLine($"Position: {position}\nSalary: {salary}");
        }
    }
}
