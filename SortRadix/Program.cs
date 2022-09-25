using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace SortRadix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello, World!");

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

            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("\nProcess START! \n");
            Console.WriteLine("Array Length: " + len + "\n");
            stopwatch.Start();

            Console.WriteLine("Bubble Sort \n");
            Console.WriteLine("Before:");
            // foreach (int  x in arr)
            //     Console.Write(x + " ");

            // ####

            radixSort(arr, len);

            // ####

            Console.WriteLine("\nSorted:");
            // foreach (int y in arr)
            //     Console.Write(y + " ");

            stopwatch.Stop();
            Console.WriteLine("\nElasped Time is {0} ms", stopwatch.ElapsedMilliseconds);
            Console.WriteLine("\nProcess END!");

        }

        public static int getMax(int[] arr, int n)
        {
            int mx = arr[0];
            for(int i = 1; i < n; i++)
            {
                if (arr[i] > mx)
                {
                    mx = arr[i];                }
            }
            return mx;
        }
        public static void radixSort(int[] arr, int n)
        {
            int m = getMax(arr, n);
            for (int exp = 1; m / exp > 0; exp *= 10)
                countSort(arr, n, exp);
        }

        public static void countSort(int[] arr, int n, int exp)
        {
            int[] output = new int[n];
            int i;
            int[] count = new int[10];
            for (i = 0; i < 10; i++)
                count[i] = 0;
            for (i = 0; i < n; i++)
                count[(arr[i] / exp) % 10]++;
            for (i = 1; i < 10; i++)
                count[i] += count[i - 1];
            for (i = n - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }
            for (i = 0; i < n; i++)
                arr[i] = output[i];

        }

    }
}