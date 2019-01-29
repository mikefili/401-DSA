using System;
using System.Collections.Generic;

namespace Trees.Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bT = new BinaryTree();
            bT.Root = new Node(5);
            bT.Root.LeftChild = new Node(10);
            bT.Root.RightChild = new Node(15);
            bT.Root.LeftChild.LeftChild = new Node(20);
            bT.Root.LeftChild.RightChild = new Node(25);

            List<int> results = bT.PreOrder(bT.Root);
            Console.WriteLine(results);
        }
    }
}
