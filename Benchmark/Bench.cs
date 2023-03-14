using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace Benchmark
{
    [MemoryDiagnoser]
    public class Bench
    {
        //private List<int> list;

        [Params(1000, 10000)]
        public int capacity;

        //[GlobalSetup]
        //public void Setup()
        //{
        //    list = new List<int>();
        //}

        [Benchmark]
        public List<int> Add()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < capacity; i++)
            {
                list.Add(i);
            }
            return list;
        }

        [Benchmark]
        public List<int> Incert()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < capacity; i++)
            {
                list.Insert(0, i);
            }
            return list;
        }

        //[Benchmark]
        //public List<int> AddRange()
        //{
        //    int[] arr =  { 1, 3, 5, 7, 9 };
        //    for (int i = 0; i < capacity; i++)
        //    {
        //        list.AddRange(arr);
        //    }
        //    return list;
        //}


        //=================================Dictionary====================//

        [Benchmark]
        public Dictionary<int, string> DictionaryAdd() {
            var countries = new Dictionary<int, string>();
            for (int i = 0; i < capacity; i++)
            {
                countries.Add(i, "Test");
            }
            return countries;
        }

        [Benchmark]
        public Dictionary<int, string> DictionaryIncert()
        {
            var countries = new Dictionary<int, string>();

            countries.Add(1, "Ukraine");
            countries.Add(3, "Ukraine");

            for (int i = 0; i < capacity; i++)
            {
                if(countries.TryAdd(i, "Test"))
                {
                    //
                }
                else
                {
                    Console.WriteLine("Fail");
                }
            }
            return countries;
        }
    }
}