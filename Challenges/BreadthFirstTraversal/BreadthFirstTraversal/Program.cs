using System;
using System.Collections.Generic;
using Trees.Classes;

namespace BreadthFirstTraversal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(2);
            root.LeftChild = new Node(7);
            root.RightChild = new Node(5);
            root.LeftChild.LeftChild = new Node(2);
            root.LeftChild.RightChild = new Node(6);
            root.LeftChild.RightChild.LeftChild = new Node(5);
            root.LeftChild.RightChild.RightChild = new Node(11);
            root.RightChild.RightChild = new Node(9);
            root.RightChild.RightChild.LeftChild = new Node(4);

            BreadthFirst(root);
        }

        public static object[] BreadthFirst(Node root)
        {
            List<object> list = new List<object>();
            Queue<Node> tree = new Queue<Node>();
            tree.Enqueue(root);

            while (tree.Count > 0)
            {

            }
            return tree.ToArray();
        }
    }
}
