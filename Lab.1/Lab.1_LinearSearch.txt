using System;
using System.Diagnostics;
class Program
{
    static void Main()
    {
        int[] arr = GenerateRandomArray(10000);
        int targetNumber = arr[new Random().Next(arr.Length)];

        Stopwatch sw = Stopwatch.StartNew();
        int index = LinearSearch(arr, targetNumber);
        sw.Stop();

        Console.WriteLine($"The number {targetNumber} has been found on {index} position!");
        Console.WriteLine($"Time taken for the algorithm is: {sw.Elapsed.TotalMilliseconds} ms!");
    }


    static int LinearSearch(int[] array, int targetNumber)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == targetNumber)
            {
                return i;
            }
        }

        return -1;
    }

    static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();

        int[] array = new int[size];

        for(int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 10000);
        }

        return array;
    }
}