using StacksAndQueues.Classes;
using System;
using Xunit;
using System.Collections.Generic;

namespace UnitTests_StacksAndQueues
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateStackWithNoNodes()
        {
            Stack stack = new Stack();
            Assert.Null(stack.Top);
        }

        [Fact]
        public void CanInstantiateStackWithOneNode()
        {
            Node node = new Node(1);
            Stack stack = new Stack(node);
            int expected = 1;
            Assert.Equal(expected, stack.Top.Value);
        }

        [Fact]
        public void CanPushNodeToStack()
        {
            Stack stack = new Stack();
            stack.Push(1);
            int expected = 1;
            Assert.Equal(expected, stack.Top.Value);
        }

        [Fact]
        public void CanPopNodeFromStack()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            int expected = 3;
            Assert.Equal(expected, stack.Pop().Value);
        }

        [Fact]
        public void CannotPopNodeFromEmptyStack()
        {
            Stack stack = new Stack();
            Assert.Null(stack.Pop());
        }
    }
}
