using System;
using System.Data;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 13, 35, 8, 32, 17 };


            QS(arr, 0, arr.Length - 1);

            Console.WriteLine("Sorted array:");

            foreach (int num in arr)

            {

                Console.Write(num + " ");


            }
        }

        static void QS(int[] arr, int S, int E)
        {
            if (S < E)
            {
                int Pi = Partation(arr, S, E);
                QS(arr, S, Pi - 1);
                QS(arr, Pi + 1, E);

            }


        }
        static int Partation(int[] arr, int S, int E)
        {
            int pivot = arr[E];
            int i = S - 1;

            for (int j = S; j < E; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[E];
            arr[E] = temp1;
            return i + 1;



        }


    }
}