using System;

namespace DynamicList
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicList l = new DynamicList();
            l.Add("zero");
            l.Add("one");
            l.Add("two");
            l.Add("three");

            Console.WriteLine(l.Count);
            Console.WriteLine(l[0]);
            Console.WriteLine(l.IndexOf("two"));
            Console.WriteLine(l.Remove(1));
            Console.WriteLine(l.Count);
            Console.WriteLine(l.Remove("three"));
            Console.WriteLine(l.Count);

            Console.WriteLine(l.Remove("four"));

        }
    }
}
