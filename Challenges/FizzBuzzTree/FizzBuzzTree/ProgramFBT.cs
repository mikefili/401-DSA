using System;
using Trees.Classes;
using System.Collections.Generic;

namespace FizzBuzzTree
{
    public class ProgramFBT
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

            object[] FBT = FizzBuzzTree(node);
            foreach (object item in FBT)
            {
                Console.Write($"[{item}] ");
            }
            Console.WriteLine();
        }

        public static object[] FizzBuzzTree(Node root)
        {
            try
            {
                if ((int)root.Value % 15 == 0)
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
                ListArray.Add(root.Value);
                if (root.LeftChild != null)
                {
                    FizzBuzzTree(root.LeftChild);
                }
                if (root.RightChild != null)
                {
                    FizzBuzzTree(root.RightChild);
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
