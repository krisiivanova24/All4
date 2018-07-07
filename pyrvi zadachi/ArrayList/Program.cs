using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList<int> list = new ArrayList<int>();
            list.Add(5);
            list.Add(34);
            list[0] = list[0] + 1;
            int element  = list.RemoveAt(0);
            for (int i = 0; i < list.Count ; i++)
            {
                Console.Write(list[i]);
            }

            Console.WriteLine();
            Console.WriteLine(element);

        }
    }
}
