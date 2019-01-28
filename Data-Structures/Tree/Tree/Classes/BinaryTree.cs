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
            if (root != null)
            {
                OrderedArray.Add(root.Value);
                PreOrder(root.LeftChild);
                PreOrder(root.RightChild);
            }
            return OrderedArray.ToArray();
        }

        public int[] InOrder(Node root)
        {
            if (root != null)
            {
                PreOrder(root.LeftChild);
                OrderedArray.Add(root.Value);
                PreOrder(root.RightChild);
            }
            return OrderedArray.ToArray();
        }

        public int[] PostOrder(Node root)
        {
            if (root != null)
            {
                PreOrder(root.LeftChild);
                PreOrder(root.RightChild);
                OrderedArray.Add(root.Value);
            }
            return OrderedArray.ToArray();
        }
    }
}
