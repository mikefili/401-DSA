using System;
using Linked_List.classes;
using ll_kth_from_end;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindKthNodeValue()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Insert(5);
            linkedList.Insert(10);
            linkedList.Insert(15);
            linkedList.Insert(20);
            linkedList.Insert(25);
            linkedList.Insert(30);
            Assert.Equal(15, Program.KthFromEnd(2, linkedList));
        }

        [Fact]
        public void CanFindKthNodeValueInLargeList()
        {
            LinkedList linkedList = new LinkedList();
            for (int i = 0; i < 1001; i++)
            {
                linkedList.Insert(1000 - i);
            }
            Assert.Equal(500, Program.KthFromEnd(500, linkedList));
        }

        [Fact]
        public void CanFindZeroNodeValue()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Insert(5);
            linkedList.Insert(10);
            linkedList.Insert(15);
            linkedList.Insert(20);
            linkedList.Insert(25);
            linkedList.Insert(30);
            Assert.Equal(5, Program.KthFromEnd(0, linkedList));
        }
    }
}
