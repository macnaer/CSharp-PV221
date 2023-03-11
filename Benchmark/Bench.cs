using BenchmarkDotNet.Attributes;

namespace Benchmark
{
    [MemoryDiagnoser]
    public class Bench
    {
        [Params(1000, 10000, 100000)]
        public int capacity;

        [Benchmark]
        public List<int> Add()
        {
            List<int> list = new List<int>();
            for(int i = 0; i < capacity; i++)
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

        [Benchmark]
        public List<int> AddRange()
        {
            int[] arr =  { 1, 3, 5, 7, 9 };
            List<int> list = new List<int>();
            for (int i = 0; i < capacity; i++)
            {
                list.AddRange(arr);
            }
            return list;
        }
    }
}