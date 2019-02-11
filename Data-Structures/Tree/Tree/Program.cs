using System;
using System.Collections.Generic;

namespace Trees.Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            // populate node values
            Node node = new Node(5);
            node.LeftChild = new Node(10);
            node.LeftChild.LeftChild = new Node(15);
            node.LeftChild.RightChild = new Node(20);
            node.RightChild = new Node(25);
            node.RightChild.LeftChild = new Node(30);
            node.RightChild.RightChild = new Node(35);

            // instantiate new binary tree
            BinaryTree bt = new BinaryTree(node);

            // traverse tree and print each node in PreOrder
            object[] preOrder = bt.PreOrder(node);
            Console.Write("PreOrder Tree: ");
            foreach (object item in preOrder)
            {
                Console.Write($"[{item}]");
            }
            Console.WriteLine();
            bt.ListArray.Clear();

            // traverse tree and print each node in InOrder
            object[] inOrder = bt.InOrder(node);
            Console.Write("InOrder Tree: ");
            foreach (object item in inOrder)
            {
                Console.Write($"[{item}]");
            }
            Console.WriteLine();
            bt.ListArray.Clear();

            // traverse tree and print each node in PostOrder
            Object[] postOrder = bt.PostOrder(node);
            Console.Write("PostOrder Tree: ");
            foreach (var item in postOrder)
            {
                Console.Write($"[{item}]");
            }
            Console.WriteLine();

            // populate bst node values
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(bst.Root, 5);
            bst.Add(bst.Root, 10);
            bst.Add(bst.Root, 15);
            bst.Add(bst.Root, 20);
            bst.Add(bst.Root, 25);
            bst.Add(bst.Root, 30);

            BinaryTree newBST = new BinaryTree(bst.Root);
            object[] bstTraversal = newBST.InOrder(newBST.Root);
            Console.WriteLine("Binary Search Tree: ");
            foreach (var item in bstTraversal)
            {
                Console.Write($"[{item}]");
            }
            Console.WriteLine();
        }
    }
}
