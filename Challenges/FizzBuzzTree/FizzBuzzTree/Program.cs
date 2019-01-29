using System;
using Trees.Classes;
using System.Collections.Generic;

namespace FizzBuzzTree
{
    public class Program
    {
        public static List<object> ListArray = new List<object>();

        static void Main(string[] args)
        {
            Node node = new Node(3);
            node.LeftChild = new Node(4);
            node.LeftChild.LeftChild = new Node(5);
            node.LeftChild.RightChild = new Node(6);
            node.RightChild = new Node(8);
            node.RightChild.LeftChild = new Node(10);
            node.RightChild.RightChild = new Node(15);
        }
    }
}
