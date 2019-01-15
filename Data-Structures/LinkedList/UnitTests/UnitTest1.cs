using System;
using Linked_List;
using Linked_List.classes;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanInsertBefore()
        {
            LinkedList list = new LinkedList();
            list.Insert(5);
            list.Insert(10);
            list.Insert(15);
            list.InsertBefore(10, 12);

            int[] expectedValues = { 15, 12, 10, 5 };
            int[] actualValues = new int[4];
            int i = 0;
            list.Current = list.Head;
            while (list.Current != null)
            {
                actualValues[i] = list.Current.Value;
                list.Current = list.Current.Next;
                i++;
            };
            Assert.Equal(expectedValues, actualValues);
        }

        


        [Fact]
        public void CanInsertAfter()
        {
            LinkedList list = new LinkedList();
            list.Insert(5);
            list.Insert(10);
            list.Insert(15);
            list.InsertAfter(10, 8);

            int[] expectedValues = { 15, 10, 8, 5 };
            int[] actualValues = new int[4];
            int i = 0;
            list.Current = list.Head;
            while (list.Current != null)
            {
                actualValues[i] = list.Current.Value;
                list.Current = list.Current.Next;
                i++;
            };
            Assert.Equal(expectedValues, actualValues);
        }

        [Fact]
        public void CanInsertSingleValue()
        {
            LinkedList list = new LinkedList();
            list.Insert(5);
            LinkedList expectedList = new LinkedList()
            {
                Current = null,
                Head = new Node(5) { Next = null, Value = 5 }
            };
            Assert.Equal(expectedList.Head.Value, list.Head.Value);
        }

        [Fact]
        public void CanInsertMultipleValues()
        {
            LinkedList list = new LinkedList();
            list.Insert(5);
            list.Insert(10);
            list.Insert(15);

            int[] expectedValues = { 15, 10, 5 };
            int[] actualValues = new int[3];
            int i = 0;
            list.Current = list.Head;
            while(list.Current != null)
            {
                actualValues[i] = list.Current.Value;
                list.Current = list.Current.Next;
                i++;
            };
            Assert.Equal(expectedValues, actualValues);
        }

        [Fact]
        public void CanFindValueInList()
        {
            LinkedList list = new LinkedList();
            list.Insert(5);
            list.Insert(10);
            list.Insert(15);

            Assert.True(list.Includes(10));
        }

        [Fact]
        public void CannotFindValueInList()
        {
            LinkedList list = new LinkedList();
            list.Insert(5);
            list.Insert(10);
            list.Insert(15);

            Assert.False(list.Includes(20));
        }

        [Fact]
        public void CanFindNegativeValue()
        {
            LinkedList list = new LinkedList();
            list.Insert(-5);

            Assert.True(list.Includes(-5));
        }

        [Fact]
        public void CanFindNull()
        {
            LinkedList list = new LinkedList();
            list.Insert(5);
            LinkedList expectedList = new LinkedList()
            {
                Current = null,
                Head = new Node(5) { Next = null, Value = 5 }
            };
            Assert.Null(list.Head.Next);
        }

        [Fact]
        public void CanReturnExampleLinkedList()
        {
            Assert.NotNull(Program.ExampleList());
        }

        //[Fact]
        //public void CanAppendNode()
        //{
        //    LinkedList list = new LinkedList();
        //    list.Insert(5);
        //    list.Insert(10);
        //    list.Insert(15);
        //    list.Append(16);

        //    int[] expectedValues = { 15, 10, 5, 16 };
        //    Assert.Equal(expectedValues, this);
        //}
    }
}
