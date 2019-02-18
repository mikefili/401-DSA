using System;
using Xunit;
using InsertionSort;

namespace UnitTests_InsertionSort
{
    public class UnitTest1
    {
        [Fact]
        public void CanSortUnsortedArray()
        {
            int[] unsortedArr = { 1, 5, 3 };
            int[] expectedArr = { 1, 3, 5 };
            Assert.Equal(expectedArr, Program.InsertionSort(unsortedArr));
        }

        [Fact]
        public void CanReturnSortedArrayUnchanged()
        {
            int[] sortedArr = { 1, 3, 5 };
            int[] expectedArr = { 1, 3, 5 };
            Assert.Equal(expectedArr, Program.InsertionSort(sortedArr));
        }
    }
}
