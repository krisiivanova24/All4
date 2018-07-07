using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uravnovesenMassive
{
    class Program
    { // IMA DRUG DOVYRSHEN
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<int> arr = Console.ReadLine().Split().Select(int.Parse).ToList();
            num = num / 2;
            List<int> output = new List<int>();
            Sort(arr, num, output);
            
            Console.WriteLine(string.Join(" ", arr));
            
        }
        static List<int> Sort(List<int> arr, int num, List<int> output)
        {
            for (int i = 0; i < num-1; i++)
			{
			 for (int j = 0; j < num -1; j++)
			  {
			   if (arr[j] > arr[j+1])
	              {
		           int g = arr[j+1];
                   arr[j+1] = arr[j];
                   arr[j] = g;
	              }
			  }
			}
            //output.AddRange();
            arr.RemoveRange(0, num); // ne
            
            return arr;
        }
    }
}
