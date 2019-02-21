using System;
using System.Collections.Generic;
using Trees.Classes;
using HashTable.Classes;
using StacksAndQueues.Classes;

namespace TreeIntersection
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree1 = new BinaryTree();
            tree1.Root = new Trees.Classes.Node(5);
            tree1.Root.LeftChild = new Trees.Classes.Node(10);
            tree1.Root.RightChild = new Trees.Classes.Node(1);
            tree1.Root.LeftChild.LeftChild = new Trees.Classes.Node(7);
            tree1.Root.LeftChild.RightChild = new Trees.Classes.Node(12);
            tree1.Root.RightChild.LeftChild = new Trees.Classes.Node(37);
            tree1.Root.RightChild.RightChild = new Trees.Classes.Node(93);
            tree1.Root.RightChild.LeftChild.LeftChild = new Trees.Classes.Node(52);
            tree1.Root.RightChild.RightChild.LeftChild = new Trees.Classes.Node(18);

            BinaryTree tree2 = new BinaryTree();
            tree2.Root = new Trees.Classes.Node(5);
            tree2.Root.LeftChild = new Trees.Classes.Node(9);
            tree2.Root.RightChild = new Trees.Classes.Node(1);
            tree2.Root.LeftChild.LeftChild = new Trees.Classes.Node(7);
            tree2.Root.LeftChild.RightChild = new Trees.Classes.Node(16);
            tree2.Root.RightChild.LeftChild = new Trees.Classes.Node(32);
            tree2.Root.RightChild.RightChild = new Trees.Classes.Node(93);
            tree2.Root.RightChild.RightChild.LeftChild = new Trees.Classes.Node(18);

            Console.WriteLine("Expected Common Values: 5, 1, 7, 93, 18 ");
            Console.Write("Found Common Values: ");
            var result = TreeIntersection(tree1, tree2);
            foreach (var item in result)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }

        public static List<object> TreeIntersection(BinaryTree tree1, BinaryTree tree2)
        {
            Hashtable HT = new Hashtable(1024);
            List<object> commonValues = new List<object>();
            Queue<Trees.Classes.Node> queue = new Queue<Trees.Classes.Node>();
            queue.Enqueue(tree1.Root);

            while (queue.Count > 0)
            {
                Trees.Classes.Node front = queue.Dequeue();
                HT.Add(front.Value.ToString(), front.Value.ToString());

                if (front.LeftChild != null)
                {
                    queue.Enqueue(front.LeftChild);
                }
                if (front.RightChild != null)
                {
                    queue.Enqueue(front.RightChild);
                }
            }

            Queue<Trees.Classes.Node> queue2 = new Queue<Trees.Classes.Node>();
            queue2.Enqueue(tree2.Root);

            while (queue2.Count > 0)
            {
                Trees.Classes.Node front = queue2.Dequeue();

                if (HT.Contains(front.Value.ToString()))
                {
                    commonValues.Add(front.Value);
                }
                if (front.LeftChild != null)
                {
                    queue2.Enqueue(front.LeftChild);
                }
                if (front.RightChild != null)
                {
                    queue2.Enqueue(front.RightChild);
                }
            }
            return commonValues;
        }
    }
}
