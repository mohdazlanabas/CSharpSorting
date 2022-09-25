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
            GenerateArray();
        }
        public static void GenerateArray()
        {
            // ARRAY GENERATOR

            int Min = 0;
            int Max = 1000000;
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

            Console.WriteLine("Comb Sort \n");
            Console.WriteLine("Before:");
            // foreach (int x in arr)
            //     Console.Write(x + " ");

            // MAIN PART 

            sort(arr);

            // AFTER 

            Console.WriteLine("\nSorted:");
            // foreach (int y in arr)
            //     Console.Write(y + " ");

            stopwatch.Stop();
            Console.WriteLine("\nElasped Time is {0} ms", stopwatch.ElapsedMilliseconds);
            Console.WriteLine("\nProcess END!");

        }

        public static int getNextGap( int gap)
        {
            gap = (gap * 10 / 13);
            if (gap < 1) 
            {
                return 1;
            } else
            {
                return gap;
            }
        }

        public static void sort (int[] arr)
        {
            int n = arr.Length;
            int gap = n;
            bool swapped = true;
            while (gap != 1 || swapped == true)
            {
                gap = getNextGap(gap);
                swapped = false;
                for  (int i =0; i < (n-gap); i++)
                {
                    if (arr[i] > arr[i + gap])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + gap];
                        arr[i + gap] = temp;
                        swapped = true;
                    }
                }
            }
        }




        // CLOSE BRACKETS
    }
}
