﻿using System;

namespace ArrayStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new ArrayStack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.ToArray().Length);
        }
    }
}
