using System;
using QueueWithStacks.Classes;

namespace QueueWithStacks
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Queue With Stacks!");
            QueueWithStacks();
        }

        public static void QueueWithStacks()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            PseudoQueue pseudoQueue = new PseudoQueue();
            pseudoQueue.Enqueue(6);
            pseudoQueue.Enqueue(7);
            pseudoQueue.Enqueue(8);
            pseudoQueue.Enqueue(9);
            pseudoQueue.Enqueue(10);
        }
    }
}
