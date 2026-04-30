using System;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            InterpolationSearch(arr, 6);
        }

        static void InterpolationSearch(int[] array, int data)
        {

            int low = 0, high = array.Length - 1;
            while (low <= high && data >= array[low] && data <= array[high])
            {
                int pos = low + ((data - array[low]) * (high - low)) / (array[high] - array[low]);
                if (array[pos] == data)
                {
                    Console.WriteLine("Data found succesful..");
                    return;
                }
                if (array[pos] < data)
                {
                    low = pos + 1;
                }
                else
                {
                    high = pos - 1;
                }
            }
            Console.WriteLine("Data not found..");
        }
    }
}