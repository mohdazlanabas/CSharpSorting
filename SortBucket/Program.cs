using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace SortBucket
{
    class Program
    {
        public static void Main(string[] args)
        {
            // ARRAY GENERATOR

            float[] arr = { (float)0.897, (float)0.565, (float)0.656, (float)0.124, (float)0.665, (float)0.343 };
            int n = arr.Length;

            // BEFORE

            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("\nProcess START! \n");
            Console.WriteLine("Array Length: " + n + "\n");
            stopwatch.Start();

            Console.WriteLine("Bucket Sort \n");
            Console.WriteLine("Before:");
            foreach (float x in arr)
                Console.Write(x + " ");

            // MAIN PART 

            
            bucketSort(arr, n);

            // AFTER 

            Console.WriteLine("\nSorted:");
            foreach (float y in arr)
                Console.Write(y + " ");

            stopwatch.Stop();
            Console.WriteLine("\nElasped Time is {0} ms", stopwatch.ElapsedMilliseconds);
            Console.WriteLine("\nProcess END!");
        }

        static void bucketSort(float[] arr, int n)
        {
            if (n <= 0)
                return;
            List<float>[] buckets = new List<float>[n];
            for (int i = 0; i < n; i++)
            {
                buckets[i] = new List<float>();

            }
            for (int i = 0; i < n; i++)
            {
                float idx = arr[i] * n;
                buckets[(int)idx].Add(arr[i]);
            }
            for (int i = 0; i < n; i++)
            {
                buckets[i].Sort();
            }
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    arr[index++] = buckets[i][j];
                }
            }
        }

    }
}
