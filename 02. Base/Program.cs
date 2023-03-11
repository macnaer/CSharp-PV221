using System;

namespace _02._Base
{
    internal class Program
    {
        private static void Fill(int[] arr, int start, int end)
        {
            Random random= new Random();

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(start, end);
            }
        }

        private static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
        }

        static void Main(string[] args)
        {
            //int choice = 0;
            //Console.Write("Choose number: ");
            //choice = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(choice.GetType());
            //Console.WriteLine(choice);
            //Console.WriteLine("==========================");

            //Object obj = new Object();
            //bool b = (obj is Object);
            //Console.WriteLine(b);
            //Console.WriteLine(b.GetType());

            int size = 0;
            Console.Write("Enter array size: ");
            size = Convert.ToInt32(Console.ReadLine());

            //int[] arr = new int[size];
            int[] arr = new int[size];

            Fill(arr, 50, 100);
            Print(arr);
            Console.WriteLine("===================");
            Array.Sort(arr);
            Print(arr);
            Console.WriteLine("===================");
            Array.Reverse(arr);
            Print(arr);
            Console.WriteLine("===================");
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = 100;
            Print(arr);


        }
    }
}

