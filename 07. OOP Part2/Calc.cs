using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._OOP_Part2
{
    internal struct Calc
    {
        public int X;
        public int Y;
        public Calc(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Print()
        {
            Console.WriteLine($"x = {X} : y = {Y}");
        }

    }
}
