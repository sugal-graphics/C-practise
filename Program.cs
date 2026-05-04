using System;
using System.Data;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 13, 35, 8, 32, 17 };


            MS(arr, 0, arr.Length - 1);

            Console.WriteLine("Sorted array:");

            foreach (int num in arr)

            {

                Console.Write(num + " ");

            }
        }

        static void MS(int[] arr, int S, int E)
        {
            if (S < E)
            {
                int m = S + (E - S) / 2;
                MS(arr, S, m);
                MS(arr, m + 1, E);
                Merge(arr, S, m, E);
            }


        }
        static void Merge(int[] arr, int S, int m, int E)
        {
            int[] tempArr = new int[E - S + 1];
            int i = S;
            int j = m + 1;
            int k = 0;

            while (i <= m && j <= E)
            {

                if (arr[i] < arr[j])
                {
                    tempArr[k++] = arr[i++];

                }
                else
                {
                    tempArr[k++] = arr[j++];

                }

            }
            while (i <= m)
            {
                tempArr[k++] = arr[i++];

            }
            while (j <= E)
            {
                tempArr[k++] = arr[j++];
            }

            for (int idx = 0; idx < tempArr.Length; idx++)
            {
                arr[idx + S] = tempArr[idx];
            }
        }


    }
}