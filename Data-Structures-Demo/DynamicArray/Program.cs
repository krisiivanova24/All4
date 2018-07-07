using System;
using System.Collections.Generic;

namespace DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<int> array = new DynamicArray<int>();
            array.Add(5);
            Console.WriteLine(array[0]);

            array[0] = array[0] + 1;
            int element = array.RemoveAt(0);
            Console.WriteLine(element);
            Console.WriteLine(array.Count);
        }
    }
}
