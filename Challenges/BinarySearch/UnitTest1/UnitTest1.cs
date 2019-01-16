using System;
using Xunit;
using BinarySearch;

namespace UnitTest1
{
    public class UnitTest1
    {
        [Fact]
        public void CanAcceptEvenArray()
        {
            int[] arr = { 4, 8, 15, 16, 23, 42 };
            int key = 15;
            Assert.Equal(2, Program.BinarySearch(arr, key));
        }

        [Fact]
        public void CanAcceptOddArray()
        {
            int[] arr = { 4, 8, 15, 16, 23 };
            int key = 15;
            Assert.Equal(2, Program.BinarySearch(arr, key));
        }

        [Fact]
        public void CanAcceptEmptyArray()
        {
            int[] arr = { };
            int key = 15;
            Assert.Equal(-1, Program.BinarySearch(arr, key));
        }
    }
}
