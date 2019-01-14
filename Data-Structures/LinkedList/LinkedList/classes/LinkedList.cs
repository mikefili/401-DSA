using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List.classes
{
    public class LinkedList
    {
        // Head property
        public Node Head { get; set; }
        public Node Current { get; set; }

        /// <summary>
        /// insert a new node with a chosen value
        /// </summary>
        /// <param name="value">value being added to the list</param>
        public void Insert(int value)
        {
            Node exampleNode = new Node(value); // circle
            exampleNode.Next = Head; // arrow
            Head = exampleNode; // move head to newly instantiated node
        }

        /// <summary>
        /// check to see if any nodes in the list contain a specific value
        /// </summary>
        /// <param name="value">value being checked for</param>
        /// <returns></returns>
        public bool Includes(int value)
        {
            Current = Head; // reset to Head node so that we start at the front of the LL
            while (Current.Next != null) // verify we are not at end of LL
            {
                if (Current.Value == value)
                {
                    return true;
                }
                Current = Current.Next;
            }
            if (Current.Value == value)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// prints out each node starting from the head and proceeding to null
        /// </summary>
        public void Print()
        {
            Console.Write("HEAD --> ");
            Console.Write(Head.Value);
            Console.Write(" --> ");
            Node Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
                Console.Write(Current.Value);
                Console.Write(" --> ");
            }
            Console.Write("NULL");
        }
    }
}
