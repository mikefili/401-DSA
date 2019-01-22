using StacksAndQueues.Classes;
using System;
using Xunit;

namespace UnitTests_StacksAndQueues
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddNodeToStack()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            int expected = 1;
            Assert.Equal(expected, stack.Peek().Value);
        }
    }
}
