using System;
using System.Collections.Generic;
using Trees.Classes;

namespace BreadthFirstTraversal
{
    public class Program
    {
        static void Main(string[] args)
        {
            // populate tree with nodes
            Node root = new Node(2);
            root.LeftChild = new Node(7);
            root.RightChild = new Node(5);
            root.LeftChild.LeftChild = new Node(2);
            root.LeftChild.RightChild = new Node(6);
            root.LeftChild.RightChild.LeftChild = new Node(5);
            root.LeftChild.RightChild.RightChild = new Node(11);
            root.RightChild.RightChild = new Node(9);
            root.RightChild.RightChild.LeftChild = new Node(4);

            Console.WriteLine("Expected Output:");
            Console.WriteLine(2);
            Console.WriteLine(7);
            Console.WriteLine(5);
            Console.WriteLine(2);
            Console.WriteLine(6);
            Console.WriteLine(9);
            Console.WriteLine(5);
            Console.WriteLine(11);
            Console.WriteLine(4);
            Console.WriteLine();
            Console.WriteLine("Actual Output:");
            Console.WriteLine(BreadthFirst(root)[2]);
        }

        /// <summary>
        /// breadth first tree traversal method
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static object[] BreadthFirst(Node root)
        {
            List<object> list = new List<object>();
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                Node front = queue.Dequeue();
                list.Add(front.Value);
                Console.WriteLine($"{front.Value} ");

                if (front.LeftChild != null)
                {
                    queue.Enqueue(front.LeftChild);
                }

                if (front.RightChild != null)
                {
                    queue.Enqueue(front.RightChild);
                }
            }
            return list.ToArray();
        }
    }
}
