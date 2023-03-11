using Benchmark;
using BenchmarkDotNet.Running;

namespace _03._List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> countries = new List<string>();

            //countries.Add("Ukraine");
            //countries.Add("France");
            //countries.Add("Swizerland");

            //Console.WriteLine("=====================Add====================");
            //Console.WriteLine($"List count: {countries.Count}");
            //foreach (string country in countries)
            //{
            //    Console.WriteLine(country);
            //}

            //Console.WriteLine("=====================Sort====================");
            //countries.Sort();
            //Console.WriteLine($"List count: {countries.Count}");
            //foreach (string country in countries)
            //{
            //    Console.WriteLine(country);
            //}

            //Console.WriteLine("=====================Revers====================");
            //countries.Reverse();
            //Console.WriteLine($"List count: {countries.Count}");
            //foreach (string country in countries)
            //{
            //    Console.WriteLine(country);
            //}

            //Console.WriteLine("=====================Insert====================");
            //countries.Insert(1, "Germany");
            //Console.WriteLine($"List count: {countries.Count}");
            //foreach (string country in countries)
            //{
            //    Console.WriteLine(country);
            //}

            //Console.WriteLine("=====================AddRange====================");
            //string[] strings = { "Italy", "Portugal", "Poland" };
            //countries.AddRange(strings);
            //Console.WriteLine($"List count: {countries.Count}");
            //foreach (string country in countries)
            //{
            //    Console.WriteLine(country);
            //}

            //Console.WriteLine("=====================RemoveByName====================");
            //countries.Remove("Germany");
            //Console.WriteLine($"List count: {countries.Count}");
            //foreach (string country in countries)
            //{
            //    Console.WriteLine(country);
            //}

            //Console.WriteLine("=====================RemoveByIndex====================");
            //countries.RemoveAt(2);
            //Console.WriteLine($"List count: {countries.Count}");
            //foreach (string country in countries)
            //{
            //    Console.WriteLine(country);
            //}

            //Console.WriteLine("=====================Contains====================");
            //bool result = countries.Contains("Ukraine");
            //Console.WriteLine(result);
            //Console.WriteLine($"List count: {countries.Count}");
            //foreach (string country in countries)
            //{
            //    Console.WriteLine(country);
            //}


            //========================Benchmark====================
            var result = BenchmarkRunner.Run<Bench>();
        }
    }
}