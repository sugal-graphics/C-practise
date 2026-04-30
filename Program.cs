using System;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            BinarySearch(arr, 4);
        }

        static void BinarySearch(int[] array, int data)
        {

            int low = 0, high = array.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (array[mid] == data)
                {
                    Console.WriteLine("Data found suceesful..");
                    return;
                }
                else if (array[mid] > data)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            Console.WriteLine("Data not found..");
        }
    }
}