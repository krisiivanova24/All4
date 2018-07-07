using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addAndSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ushort> massive1 = Console.ReadLine().Split(' ').Select(ushort.Parse).ToList();
            ushort[] massive2 = massive1.ToArray() ;           
            
            massive1.Add(ushort.Parse(Console.ReadLine()));
            massive1.Sort();
            Console.WriteLine(string.Join(" ", massive2));
            Console.WriteLine(string.Join(" ", massive1));
        }
    }
}
