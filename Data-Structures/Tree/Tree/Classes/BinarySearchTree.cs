using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public BinarySearchTree(Node node)
        {
            Root = null;
        }

        public BinarySearchTree()
        {

        }

        public Node Add(Node root, object value)
        {
            Node node = new Node(value);
            if (Root == null)
            {
                Root = node;
                return node;
            }
            Node parent = null;
            while (root != null)
            {
                parent = root;
                if ((int)value < (int)root.Value)
                {
                    root = root.LeftChild;
                }
                else
                {
                    root = root.RightChild;
                }
            }
            if ((int)value <= (int)parent.Value)
            {
                parent.LeftChild = node;
            }
            else
            {
                parent.RightChild = node;
            }
            return root;
        }
    }
}
