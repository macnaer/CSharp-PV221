using Benchmark;
using BenchmarkDotNet.Running;

namespace _04._Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var countries = new  Dictionary<int, string>();
            //countries.Add(1, "Ukraine");
            //countries.Add(3, "Poland");
            //countries.Add(6, "Italy");
            //countries.Add(4, "France");
            //countries.Add(2, "Germany");

            //Console.WriteLine(countries[1]);

            //Console.WriteLine("==============Keys====================");
            //foreach(var key in countries.Keys)
            //{
            //    Console.WriteLine(key);
            //}


            //Console.WriteLine("==============Values====================");
            //foreach (var value in countries.Values)
            //{
            //    Console.WriteLine(value);
            //}

            //Console.WriteLine("==============Keys & Values====================");
            //foreach(var country in countries)
            //{
            //    Console.WriteLine($"{country.Key} => {country.Value} ");
            //}

            //if(countries.TryAdd(6, "Spain"))
            //{
            //    Console.WriteLine("Spain is added.");
            //}
            //else
            //{
            //    Console.WriteLine("Failed index");
            //}

            //Console.WriteLine($"Countries count: {countries.Count}");
            //Console.WriteLine($"Check index: {countries.ContainsKey(6)}");
            //Console.WriteLine($"Check value: {countries.ContainsValue("France")}");


            //Console.WriteLine("==============Remove ====================");

            //countries.Remove(4);
            //foreach (var country in countries)
            //{
            //    Console.WriteLine($"{country.Key} => {country.Value} ");
            //}


            //========================Benchmark====================
            var result = BenchmarkRunner.Run<Bench>();

        }
    }
}