using System;
using Xunit;
using BreadthFirstTraversal;
using Trees.Classes;

namespace UnitTests_BreadthFirstTraversal
{
    public class UnitTest1
    {
        [Fact]
        public void CanPerformBreadthFirstTraversal()
        {
            Node root = new Node(5);
            root.LeftChild = new Node(12);
            root.RightChild = new Node(42);
            root.LeftChild.LeftChild = new Node(9);
            root.LeftChild.RightChild = new Node(18);
            root.LeftChild.RightChild.LeftChild = new Node(53);
            root.LeftChild.RightChild.RightChild = new Node(4);
            root.RightChild.RightChild = new Node(21);
            root.RightChild.RightChild.LeftChild = new Node(6);
            object[] actual = BreadthFirstTraversal.Program.BreadthFirst(root);

            Assert.Equal(42, actual[2]);
        }
    }
}
