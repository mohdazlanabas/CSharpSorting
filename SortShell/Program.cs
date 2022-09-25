using System;
using System.Diagnostics;
using System.Globalization;

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
            int len = 10000000; // array length

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

            Console.WriteLine("Shell Sort \n");
            Console.WriteLine("Before:");
            // foreach (int x in arr)
            //     Console.Write(x + " ");

            // MAIN PART 

            sort(arr);

            // AFTER 

            Console.WriteLine("\nSorted:");
            // foreach (int y in arr)
            //    Console.Write(y + " ");

            stopwatch.Stop();
            Console.WriteLine("\nElasped Time is {0} ms", stopwatch.ElapsedMilliseconds);
            Console.WriteLine("\nProcess END!");

        }
        static int sort(int[] arr)
        {
            int n = arr.Length;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i += 1)
                {
                    int temp = arr[i];
                    int j;
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                        arr[j] = arr[j - gap];
                    arr[j] = temp;
                }
            }
            return 0;
        }


// END BRACKETS
    }
}
