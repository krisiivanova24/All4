using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pyrva_zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort[] massiv = Console.ReadLine().Split().Select(ushort.Parse).ToArray();
            ushort num = ushort.Parse(Console.ReadLine());
            Find(num, massiv);
        }
        static void Find(ushort num, ushort[] massive) {
            if (massive.Contains(num))
            {
                Console.WriteLine($"{num} Exists in the List");
            }
            else
            {
                Console.WriteLine($"{num} Not exists in the List");
            }
}
    }
}
