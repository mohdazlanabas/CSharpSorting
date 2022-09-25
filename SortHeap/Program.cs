using System;
using System.Diagnostics;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

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
            int Max = 1000000;
            int len = 10000000; // array length
           // int temp;

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

            Console.WriteLine("Heap Sort \n");
            Console.WriteLine("Before:");
            // foreach (int m in arr)
            //    Console.Write(m + " ");

            // MAIN PART

            sort(arr);

            // AFTER 

            Console.WriteLine("\nSorted:");
           //  foreach (int n in arr)
           //      Console.Write(n + " ");

            stopwatch.Stop();
            Console.WriteLine("\nElasped Time is {0} ms", stopwatch.ElapsedMilliseconds);
            Console.WriteLine("\nProcess END!");

        }

        public static void sort(int[] arr) // why this needs to be public
        {
            int N = arr.Length;
            // Build Heap
            for (int i = N / 2 - 1; i >= 0; i--)
                heapify(arr, N, i);

            // Extract element Form Heap
            for (int i = N - 1; i > 0; i--)
            {
                // Move Root To End
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                // Max Heapify
                heapify(arr, i, 0);
            }
        }

        static void heapify (int[] arr, int N, int i) // why this not need to be public
        {
                int largest = i; // initialize largest root
                int l = 2 * i + 1; // left
                int r = 2 * i + 2; // right

                // if left chile larger than root
                if ( l < N && arr[l] > arr[largest])
                    largest = l;
                if (r < N && arr[r] > arr[largest])
                    largest = r;
                if (largest != i)
                {
                    int swap = arr[i];
                    arr[i] = arr[largest];
                    arr[largest] = swap;
                    // Recursively heapify the affected sub tree
                    heapify(arr, N, largest); 
                }
            }


        // ## CLOSING BRACKETS
        }
    }




