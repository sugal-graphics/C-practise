using System;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            LinearSearch(arr, 4);
        }

        static void LinearSearch(int[] array, int data)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == data)
                {
                    Console.WriteLine("Data found succesful...");
                    return;
                }


            }
            Console.WriteLine("Data not found");
        }
    }
}