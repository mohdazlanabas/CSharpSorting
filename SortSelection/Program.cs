using System;
using System.Diagnostics;
using System.Xml.Schema;

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

Console.WriteLine("Selection Sort \n"); // CHANGE SORTING ANME
Console.WriteLine("Before:");
// foreach (int m in arr)
//    Console.Write(m + " ");

// ##

int smallest; // nee declare variable always

for (i = 0; i < len - 1; i++)
{
    smallest = i;
    for (j = i + 1; j < len; j++)
    {
        if (arr[j] < arr[smallest])
        {
            smallest = j;
        }
    }
    temp = arr[smallest];
    arr[smallest] = arr[i];
    arr[i] = temp;
}

 // ##

Console.WriteLine("\nSorted:");
// foreach (int n in arr)
//    Console.Write(n + " ");

stopwatch.Stop();
Console.WriteLine("\nElasped Time is {0} ms", stopwatch.ElapsedMilliseconds);
Console.WriteLine("\nProcess END!");