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
            //countries.Add("USA");

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

            //Console.WriteLine("=====================Find====================");
            //string res = countries.Find(name => name.StartsWith("U"));
            //Console.WriteLine(res);

            //Console.WriteLine("=====================FindAll====================");
            //List<string> longWords = countries.FindAll(word => word.Length > 5);

            //Console.WriteLine("Words with length greater than 5:");
            //foreach (string word in longWords)
            //{
            //    Console.WriteLine(word);
            //}

            //Console.WriteLine("=====================FindAll====================");
            //List<string> u = countries.FindAll(word => word.StartsWith("U"));

            //Console.WriteLine("Words with length greater than 5:");
            //foreach (string word in u)
            //{
            //    Console.WriteLine(word);
            //}



            //========================Benchmark====================
            var result = BenchmarkRunner.Run<Bench>();
        }
    }
}