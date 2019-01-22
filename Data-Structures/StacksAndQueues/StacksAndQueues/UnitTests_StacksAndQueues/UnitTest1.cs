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

        [Fact]
        public void CanPeekAtTopNode()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            int expected = 3;
            Assert.Equal(expected, stack.Peek().Value);
        }

        [Fact]
        public void CannotPeekInEmptyStack()
        {
            Stack stack = new Stack();
            Assert.Null(stack.Peek());
        }

        [Fact]
        public void CanInstantiateQueueWithNoNodes()
        {
            Queue queue = new Queue();
            Assert.Null(queue.Front);
        }

        [Fact]
        public void CanInstantiateQueueWithOneNode()
        {
            Node node = new Node(1);
            Queue queue = new Queue(node);
            int expected = 1;
            Assert.Equal(expected, queue.Front.Value);
        }

        [Fact]
        public void CanEnqueueNodeToEmptyQueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            int expected = 1;
            Assert.Equal(expected, queue.Rear.Value);
        }

        [Fact]
        public void CanEnqueueNodeToQueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            int expected = 3;
            Assert.Equal(expected, queue.Rear.Value);
        }
    }
}
