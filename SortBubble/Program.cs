using System;
using System.Diagnostics;

int i;
int j;
int temp;

// ARRAY GENERATOR
int Min = 0;
int Max = 1000000;
int len = 10000; // array length

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
// foreach (int m in arr)
//    Console.Write(m + " ");

for (i = 0; i <= arr.Length - 2; i++)
{
    for (j = 0; j <= arr.Length - 2; j++)
    {
        if (arr[j] > arr[j + 1])
        {
            temp = arr[j + 1];
            arr[j + 1] = arr[j];
            arr[j] = temp;
        }
    }
}
Console.WriteLine("\nSorted:");
// foreach (int n in arr)
//    Console.Write(n + " ");

stopwatch.Stop(); 
Console.WriteLine("\nElasped Time is {0} ms", stopwatch.ElapsedMilliseconds);
Console.WriteLine("\nProcess END!");
