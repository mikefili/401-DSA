using System;
using System.Collections.Generic;

namespace Trees.Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node(5);
            node.LeftChild = new Node(10);
            node.LeftChild.LeftChild = new Node(15);
            node.LeftChild.RightChild = new Node(20);
            node.RightChild = new Node(25);
            node.RightChild.LeftChild = new Node(30);
            node.RightChild.RightChild = new Node(35);

            BinaryTree bt1 = new BinaryTree(node);
            BinaryTree bt2 = new BinaryTree(node);

            object[] result1 = bt1.PreOrder(node);
            foreach (object item in result1)
            {
                Console.Write($"[{item}]");
            }

            Console.WriteLine();
            bt1.ListArray.Clear();

        }
    }
}
