using System;
using Xunit;
using FindMaximumValue;
using Trees.Classes;

namespace UnitTests_FindMaximumValue
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindMaxValue()
        {
            Node node = new Node(15);
            node.LeftChild = new Node(48);
            node.RightChild = new Node(22);
            node.LeftChild.LeftChild = new Node(1081);
            node.LeftChild.RightChild = new Node(73);
            Assert.Equal(1081, ProgramFMV.FindMaxValue(node));
        }
    }
}
