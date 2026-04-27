using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class HashTable
{

    public int size = 10;
    public List<int>[] table;

    public HashTable()
    {
        table = new List<int>[size];
        for (int i = 0; i < size; i++)
        {
            table[i] = new List<int>();
        }
    }

    public int Hash(int key)
    {
        return key % size;
    }

    public void Insert(int key)
    {
        int index = Hash(key);
        Console.WriteLine($"Inserting {key} at index {index}");
        table[index].Add(key);
    }

    public void Display()
    {
        Console.WriteLine("Hash Table: ");
        for (int i = 0; i < size; i++)
        {
            Console.Write(i + ":");
            foreach (var item in table[i])
            {
                Console.Write(item + " ");

            }
            Console.WriteLine();
        }
    }
}
class Program

{

    static void Main()

    {
        HashTable ht = new HashTable();
        ht.Insert(23);
        ht.Insert(33);
        ht.Insert(24);

        ht.Display();
    }
}