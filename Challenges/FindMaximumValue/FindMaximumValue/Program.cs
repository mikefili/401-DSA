using System;
using Trees.Classes;

namespace FindMaximumValue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node nodeL = new Node(15);
            nodeL.LeftChild = new Node(48);
            nodeL.RightChild = new Node(22);
            nodeL.LeftChild.LeftChild = new Node(1081);
            nodeL.LeftChild.RightChild = new Node(73);
            nodeL.LeftChild.LeftChild.LeftChild = new Node(563);
            nodeL.RightChild.LeftChild = new Node(1);
            nodeL.RightChild.LeftChild.RightChild = new Node(889);
            nodeL.RightChild.RightChild = new Node(281);

            Console.Write("Max Value on Left Side of Tree: ");
            Console.WriteLine(FindMaxValue(nodeL));
            Console.WriteLine();

            Node nodeR = new Node(15);
            nodeR.LeftChild = new Node(48);
            nodeR.RightChild = new Node(22);
            nodeR.LeftChild.LeftChild = new Node(108);
            nodeR.LeftChild.RightChild = new Node(73);
            nodeR.LeftChild.LeftChild.LeftChild = new Node(563);
            nodeR.RightChild.LeftChild = new Node(1);
            nodeR.RightChild.LeftChild.RightChild = new Node(889);
            nodeR.RightChild.RightChild = new Node(281);

            Console.Write("Max Value on Right Side of Tree: ");
            Console.WriteLine(FindMaxValue(nodeR));
        }

        public static int FindMaxValue(Node root)
        {
            int maxVal = 0;
            if (root == null)
            {
                return maxVal;
            }
            maxVal = Convert.ToInt32(root.Value);
            int leftChildMax = FindMaxValue(root.LeftChild);
            int rightChildMax = FindMaxValue(root.RightChild);
            if (leftChildMax > maxVal)
            {
                maxVal = leftChildMax;
            }
            if (rightChildMax > maxVal)
            {
                maxVal = rightChildMax;
            }
            return maxVal;
        }
    }
}
