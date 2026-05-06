using System;
using System.Data;
using System.Globalization;
using System.Transactions;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 1, 5, 3, 2 };
            IS(arr, 5);
            Console.WriteLine("Sorted array: ");
            foreach (int num in arr)
            {
                Console.WriteLine(num + " ");
            }
        }

        static void IS(int[] arr, int n)
        {
            for (int i = 1; i < n; i++)
            {
                int current = arr[i];
                int Previous = i - 1;
                while (Previous >= 0 && arr[Previous] > current)
                {
                    arr[Previous + 1] = arr[Previous];
                    Previous--;
                }
                arr[Previous + 1] = current;
            }

        }


    }




}



