using System;
using System.Diagnostics;
using System.Globalization;

// Quick Sort is recursion
// Quicksort call upon Partition
// Partition call upon Swap

namespace AlgoSorting
{
    class Program
    {
        public static void Main(string[] args)
        {
            // ARRAY GENERATOR
            
            int Min = 0;
            int Max = 1000;
            int len = 1000000000; // array length

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

            Console.WriteLine("Quick Sort \n");
            Console.WriteLine("Before:");
            // foreach (int m in arr)
            //    Console.Write(m + " ");

            // MAIN PART

            quicksort(arr, 0, len - 1); ;

            // AFTER 

            Console.WriteLine("\nSorted:");
            // foreach (int n in arr)
           //     Console.Write(n + " ");

            stopwatch.Stop();
            Console.WriteLine("\nElasped Time is {0} ms", stopwatch.ElapsedMilliseconds);
            Console.WriteLine("\nProcess END!");

        }

        // QUCISKORT
        static void quicksort(int[] Array, int left, int right)
        {
            if (left < right)
            {
                int pivot = partition(Array, left, right);
                quicksort(Array, left, pivot - 1);
                quicksort(Array, pivot + 1, right);
            }

        }

        // PARTIION

        static int partition(int[] Array, int left, int right)
        {
            int i = left;
            int pivot = Array[right];
            int temp;

            for (int j = left; j <= right; j++)
            {
                if (Array[j] < pivot)
                {
                    temp = Array[i];
                    Array[i] = Array[j];
                    Array[j] = temp;
                    i++;
                }
            }
            temp = Array[right];
            Array[right] = Array[i];
            Array[i] = temp;
            return i;
        }

    }
}




