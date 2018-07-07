using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortMaxToMin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < arr.Count - 1; i++)
            {
                int k = i;
                for (int j = i + 1; j < arr.Count; j++)
                {

                    if (arr[k] < arr[j])//razmqna
                    {
                        k = j;
                    }
                }
                int x = arr[i];
                arr[i] = arr[k];
                arr[k] = x;

            }
            Console.WriteLine(string.Join(" ", arr));
        }

    }
}
