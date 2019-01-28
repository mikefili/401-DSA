using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinaryTree
    {
        public Node root { get; set; }
        public List<int> OrderedList { get; set; }

        public BinaryTree()
        {
            root = null;
        }

        public int[] PreOrder(Node root)
        {
            BinaryTree binaryTree = new BinaryTree();

            OrderedList.Add(root.Value);
            if (root.LeftChild != null)
            {
                PreOrder(root.LeftChild);
                OrderedList.Add(root.LeftChild.Value);
            }
            if (root.RightChild != null)
            {
                PreOrder(root.RightChild);
                OrderedList.Add(root.RightChild.Value);
            }
            return OrderedList.ToArray();
        }

        public int[] InOrder(Node root)
        {
            BinaryTree binaryTree = new BinaryTree();

            if (root.LeftChild != null)
            {
                InOrder(root.LeftChild);
                OrderedList.Add(root.LeftChild.Value);
            }
            OrderedList.Add(root.Value);
            if (root.RightChild != null)
            {
                InOrder(root.RightChild);
                OrderedList.Add(root.RightChild.Value);
            }
            return OrderedList.ToArray();
        }

        public int[] PostOrder(Node root)
        {
            BinaryTree binaryTree = new BinaryTree();

            if (root.LeftChild != null)
            {
                PostOrder(root.LeftChild);
                OrderedList.Add(root.LeftChild.Value);
            }
            if (root.RightChild != null)
            {
                PostOrder(root.RightChild);
                OrderedList.Add(root.RightChild.Value);
            }
            OrderedList.Add(root.Value);
            return OrderedList.ToArray();
        }
    }
}
