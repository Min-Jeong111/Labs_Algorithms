using System;
using System.Diagnostics;
using System.Threading.Channels;


class Program
{
    static void Main()
    {
        int[] sortedArray = GenerateSortedArray(10000);
        int target = new Random().Next(1, 10000);

        Stopwatch sw = Stopwatch.StartNew();
        int indexIterative = BinarySearch(sortedArray, target);
        sw.Stop();

        Console.WriteLine($"The target number - {target} - is at index: {indexIterative}");
        Console.WriteLine($"The average time taken for executing the algorithm is: {sw.ElapsedTicks} ticks");
    }

    static int BinarySearch(int[] array, int target)
    {
        int left = 0, right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid] == target)
            {
                return mid;
            }

            if (array[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1; // If no elements found
    }

    static int[] GenerateSortedArray(int size)
    {
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = i + 1;
        }

        return array;
    }
}