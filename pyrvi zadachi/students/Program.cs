using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace students
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int k = i;
                for (int t = i + 1; t < arr.Length; t++)
                {
                    if (arr[k] > arr[t])
                    {
                        k = t;
                    }
                    int y = arr[k];
                    arr[k] = arr[t];
                    arr[t] = y;
                }
            }
            Console.WriteLine(string.Join(", ", arr));
            if (arr2[1] == arr.Length)
            {
                arr2[1]--;
            }
            int length = arr.Length;
            for (int i = 0; i < arr2.Length; i++)
            {
                for (int w = 0; w <arr.Length ; w++)
                {
                    //Console.WriteLine(arr2[i] + " iiiii");
                    //Console.WriteLine(w + " wwww");
                    if (arr2[i] == w)
                    {
                        Console.WriteLine(arr[w]);
                    }
                }
            } 
        }
    }
}
