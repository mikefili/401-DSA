using StacksAndQueues.Classes;
using System;
using Xunit;

namespace UnitTests_StacksAndQueues
{
    public class UnitTest1
    {
        [Fact]
        public void CanPushNodeToStack()
        {
            Stack stack = new Stack();
            stack.Push(1);
            int expected = 1;
            Assert.Equal(expected, stack.Top.Value);
        }
    }
}
