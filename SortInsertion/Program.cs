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

Console.WriteLine("Insertion Sort \n"); // CHANGE SORTING ANME
Console.WriteLine("Before:");
// Print Before
// foreach (int m in arr)
// Console.Write(m + " ");

// ##

for (i =1; i <  len; i++)
{
    temp = arr[i];

    for (j = i -1; j >= 0;)
    {
        if (temp < arr[j])
        {
            arr[j + 1] = arr[j];
            j--;
            arr[j + 1] = temp;
        }
        else
        {
            break;
        }
    }
}


// ##

Console.WriteLine("\nSorted:");
// Print After
// foreach (int n in arr)
// Console.Write(n + " ");

stopwatch.Stop();
Console.WriteLine("\nElasped Time is {0} ms", stopwatch.ElapsedMilliseconds);
Console.WriteLine("\nProcess END!");