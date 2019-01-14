using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List.classes
{
    class LinkedList
    {
        // Head property
        public Node Head { get; set; }
        public Node Current { get; set; }

        public void Insert(int value)
        {
            Node exampleNode = new Node(value); // circle
            exampleNode.Next = Head; // arrow
            Head = exampleNode; // move head to newly instantiated node
        }

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
            Console.ReadLine();
        }
    }
}
