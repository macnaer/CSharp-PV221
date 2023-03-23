using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._Interfaces
{
    abstract internal class Document
    {
        string TechPassport;
        public Document(string techPassport)
        {
            this.TechPassport = techPassport;
        }

        public void Print()
        {
            Console.WriteLine($"S/N: {this.TechPassport}");
        }
    }
}
