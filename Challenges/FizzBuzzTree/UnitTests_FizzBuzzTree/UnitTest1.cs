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

        [Fact]
        public void NodeReturnsFizzBuzz()
        {
            ProgramFBT.ListArray.Clear();
            Node node = new Node(15);
            object[] FBT = ProgramFBT.FizzBuzzTree(node);
            Assert.Equal("FizzBuzz", FBT[0]);
        }

        [Fact]
        public void InapplicableNodeReturnsUnchangedValue()
        {
            ProgramFBT.ListArray.Clear();
            Node node = new Node(8);
            object[] FBT = ProgramFBT.FizzBuzzTree(node);
            Assert.Equal(8, FBT[0]);
        }
    }
}
