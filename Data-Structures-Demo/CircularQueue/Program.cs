using System;
using System.Linq;

namespace CircularQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var que = new CircularQueue<int>();

            que.Enqueue(2);
            que.Enqueue(4);
            que.Enqueue(5);
            que.Enqueue(8);
            que.Enqueue(9);

            Console.WriteLine(que.Dequeue());
            Console.WriteLine(que.Dequeue());
            Console.WriteLine(que.ToArray().Length);
        }
    }
}
