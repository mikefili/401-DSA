using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinaryTree
    {
        public Node root { get; set; }
        public List<int> OrderedArray { get; set; }

        public BinaryTree()
        {
            root = null;
        }

        public int[] PreOrder(Node root)
        {

            OrderedArray.Add(root.Value);
            if (root.LeftChild != null)
            {
                InOrder(root.LeftChild);
                OrderedArray.Add(root.LeftChild.Value);
            }
            if (root.RightChild != null)
            {
                InOrder(root.RightChild);
                OrderedArray.Add(root.RightChild.Value);
            }
            return OrderedArray.ToArray();
        }

        public int[] InOrder(Node root)
        {
            BinaryTree binaryTree = new BinaryTree();
            if (root.LeftChild != null)
            {
                InOrder(root.LeftChild);
                OrderedArray.Add(root.LeftChild.Value);
            }
            OrderedArray.Add(root.Value);
            if (root.RightChild != null)
            {
                InOrder(root.RightChild);
                OrderedArray.Add(root.RightChild.Value);
            }
            return OrderedArray.ToArray();
        }

        public int[] PostOrder(Node root)
        {
            BinaryTree binaryTree = new BinaryTree();
            if (root.LeftChild != null)
            {
                InOrder(root.LeftChild);
                OrderedArray.Add(root.LeftChild.Value);
            }
            if (root.RightChild != null)
            {
                InOrder(root.RightChild);
                OrderedArray.Add(root.RightChild.Value);
            }
            OrderedArray.Add(root.Value);
            return OrderedArray.ToArray();
        }
    }
}
