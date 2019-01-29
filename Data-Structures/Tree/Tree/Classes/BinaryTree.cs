using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public List<object> ListArray = new List<object>();

        public BinaryTree(Node node)
        {
            Root = null;
        }

        public BinaryTree()
        {

        }

        public object[] PreOrder(Node root)
        {
            try
            {
                ListArray.Add(root.Value);
                if (root.LeftChild != null)
                {
                    PreOrder(root.LeftChild);
                }
                if (root.RightChild != null)
                {
                    PreOrder(root.RightChild);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ListArray.ToArray();
        }

        public object[] InOrder(Node root)
        {
            try
            {
                if (root.LeftChild != null)
                {
                    InOrder(root.LeftChild);
                }
                ListArray.Add(root.Value);
                if (root.RightChild != null)
                {
                    InOrder(root.RightChild);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ListArray.ToArray();
        }

        public int[] PostOrder(Node root)
        {
            BinaryTree binaryTree = new BinaryTree();

            if (root.LeftChild != null)
            {
                PostOrder(root.LeftChild);
                ListArray.Add(root.LeftChild.Value);
            }
            if (root.RightChild != null)
            {
                PostOrder(root.RightChild);
                ListArray.Add(root.RightChild.Value);
            }
            ListArray.Add(root.Value);
            return ListArray.ToArray();
        }
    }
}
