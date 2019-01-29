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

        public static object[] FizzBuzzTree(Node root)
        {
            try
            {
                if ((int)root.Value % 5 == 0 && (int)root.Value % 3 == 0)
                {
                    root.Value = "FizzBuzz";
                }
                else if ((int)root.Value % 3 == 0)
                {
                    root.Value = "Fizz";
                }
                else if ((int)root.Value % 5 == 0)
                {
                    root.Value = "Buzz";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ListArray.ToArray();
        }
    }
}
