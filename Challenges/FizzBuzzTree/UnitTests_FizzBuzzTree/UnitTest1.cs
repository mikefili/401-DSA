using System;
using Xunit;
using FizzBuzzTree;
using Trees.Classes;

namespace UnitTests_FizzBuzzTree
{
    public class UnitTest1
    {
        [Fact]
        public void NodeReturnsFizz()
        {
            ProgramFBT.ListArray.Clear();
            Node node = new Node(9);
            object[] FBT = ProgramFBT.FizzBuzzTree(node);
            Assert.Equal("Fizz", FBT[0]);
        }

        [Fact]
        public void NodeReturnsBuzz()
        {
            ProgramFBT.ListArray.Clear();
            Node node = new Node(10);
            object[] FBT = ProgramFBT.FizzBuzzTree(node);
            Assert.Equal("Buzz", FBT[0]);
        }
    }
}
