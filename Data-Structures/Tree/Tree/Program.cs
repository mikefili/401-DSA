using System;
using System.Collections.Generic;

namespace Trees.Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bT = new BinaryTree();
            bT.root = new Node(5);
            bT.root.LeftChild = new Node(10);
            bT.root.RightChild = new Node(15);
            bT.root.LeftChild.LeftChild = new Node(20);
            bT.root.LeftChild.RightChild = new Node(25);

            List<int> results = bT.PreOrder(bT.root);
            Console.WriteLine(results);
        }
    }
}
