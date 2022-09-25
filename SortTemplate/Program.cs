using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace AlgoSorting
{
    class Program
    {
        public static void Main(string[] args)
        {
            GenerateArray();
        }
        public static void GenerateArray()
        {
            // ARRAY GENERATOR

            int Min = 0;
            int Max = 1000000;
            int len = 5; // array length

            int[] arr = new int[len];
            Random randNum = new Random();
            for (int r = 0; r < arr.Length; r++)
            {
                arr[r] = randNum.Next(Min, Max);
            }

            // BEFORE

            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("\nProcess START! \n");
            Console.WriteLine("Array Length: " + len + "\n");
            stopwatch.Start();

            Console.WriteLine(" ### Sort \n");
            Console.WriteLine("Before:");
            foreach (int m in arr)
                Console.Write(m + " ");

            // MAIN PART 

            // #####

            // AFTER 

            Console.WriteLine("\nSorted:");
            // foreach (int n in arr)
            // Console.Write(n + " ");

            stopwatch.Stop();
            Console.WriteLine("\nElasped Time is {0} ms", stopwatch.ElapsedMilliseconds);
            Console.WriteLine("\nProcess END!");

        }


    }
}
