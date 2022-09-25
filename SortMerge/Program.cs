using System;
using System.Diagnostics;
using System.Globalization;

namespace SortMerge
{
    internal class Program
    {
        static void Main(string[] args)
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

            Console.WriteLine("Merge Sort \n");
            Console.WriteLine("Before:");
            // foreach (int m in arr)
                // Console.Write(m + " ");

            // ###

            sort(arr, 0, len - 1);

            // ###

            // AFTER 

            Console.WriteLine("\nSorted:");
            // foreach (int n in arr)
               // Console.Write(n + " ");

            stopwatch.Stop();
            Console.WriteLine("\nElasped Time is {0} ms", stopwatch.ElapsedMilliseconds);
            Console.WriteLine("\nProcess END!");
        }

        // Main function that sorts arr[l..r] using merge()
        static void sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                // Find the middle point
                int middle = left + (right - left) / 2;
                // Sort first and second halves
                sort(arr, left, middle);
                sort(arr, middle + 1, right);
                // Merge the sorted halves
                merge(arr, left, m, right);
            }
        }
        static void merge(int[] arr, int left, int middle, int right)
            {
                // Find sizes of two subarrays to be merged
                int n1 = middle - left + 1;
                int n2 = right - middle;
                // Create temp arrays
                int[] L = new int[n1];
                int[] R = new int[n2];
                int i, j;
                // Copy data to temp arrays
                for (i = 0; i < n1; ++i)
                    L[i] = arr[l + i];
                for (j = 0; j < n2; ++j)
                    R[j] = arr[m + 1 + j];
                // Merge the temp arrays Initial indexes of first and second subarrays
                i = 0;
                j = 0;
                // Initial index of merged subarray array
                int k = left;
                while (i < n1 && j < n2)
                {
                    if (L[i] <= R[j])
                    {
                        arr[k] = L[i];
                        i++;
                    }
                    else
                    {
                        arr[k] = R[j];
                        j++;
                    }
                    k++;
                }
                // Copy remaining elements of L[] if any
                while (i < n1)
                {
                    arr[k] = L[i];
                    i++;
                    k++;
                }
                // Copy remaining elements of R[] if any
                while (j < n2)
                {
                    arr[k] = R[j];
                    j++;
                    k++;
                }
            }



        }
    }




      



       



