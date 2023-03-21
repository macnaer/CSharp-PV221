using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._OOP_Part2
{
    internal class CalcClass
    {
        public static int counter = 0;
        public CalcClass()
        {
            counter++;
        }
        public static int Plus(params int[] arr)
        {
            int result = 0;
            foreach (int i in arr)
            {
                result += i;
            }

            return result;
        }

        public void Multiply(int a, int b, ref int result)
        {
            result = a * b;
        }


        //public void Multiply(int a, int b, out int result)
        //{
        //    result = a * b;
        //}


        //public void Multiply(int a, int b, in int result)
        //{
        //    int test = result + a + b;
        //    Console.WriteLine($"Test = {test}");
        //}
    }
}
