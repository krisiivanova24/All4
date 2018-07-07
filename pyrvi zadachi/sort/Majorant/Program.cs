using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Majorant
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int length = input.Length;
            if (length % 2 != 0)
            {
                length = length - 1;
            }
            length = length / 2 + 1;
            Sort(input);
            //Console.WriteLine(string.Join(" ", input));
           // Console.WriteLine(length + " length");
            Find(input, length);

        }
        static int[] Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int e = 0; e < arr.Length-1; e++)
                {
                    if (arr[e+1] < arr[e])
                    {
                        int a = arr[e + 1];
                        arr[e + 1] = arr[e];
                        arr[e] = a;
                    }
                }
            }
            return arr;
        }
        static void Find(int[] arr, int length) 
        {
            int count = 1;
            int maxCount = count;
            int elem = arr[0];
            int maxEle = elem;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] == arr[i+1])
                {
                    count++;
                    if (count> maxCount )
                    {
                        maxCount = count;
                        maxEle = arr[i];
                       // count = 1;
                       //Console.WriteLine(maxEle);
                        //Console.WriteLine(maxCount +" max in for");
                    }
                }
            }
            //Console.WriteLine(maxCount +"max ");
            if (maxCount >= length )
            {
                Console.WriteLine(maxEle);
            }
            else
            {
                Console.WriteLine("The majorant does not exists!");
            }
        }
    }
}
