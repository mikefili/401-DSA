using System;
using Linked_List.classes;

namespace ll_merge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList linkedList1 = new LinkedList();
            linkedList1.Insert(5);
            linkedList1.Insert(3);
            linkedList1.Insert(1);

            LinkedList linkedList2 = new LinkedList();
            linkedList2.Insert(6);
            linkedList2.Insert(4);
            linkedList2.Insert(2);

            linkedList1.Print();
            Console.WriteLine();
            linkedList2.Print();
            Console.WriteLine();
            Merge(linkedList1, linkedList2);
        }

        public static void Merge(LinkedList linkedList1, LinkedList linkedList2)
        {
            linkedList1.Current = linkedList1.Head;
            linkedList2.Current = linkedList2.Head;
            Node temp = new Node(3);
            temp = linkedList1.Head;

            while (linkedList2.Current != null && temp != null)
            {
                temp = temp.Next;
                linkedList1.Current.Next = linkedList2.Current;
                linkedList2.Current = linkedList2.Current.Next;
                linkedList1.Current = linkedList1.Current.Next;
                linkedList1.Current = temp;
                linkedList1.Current = linkedList1.Current.Next;
            }          
            if (temp != null)
            {
                linkedList1.Current.Next = linkedList2.Current;
            }
            else if (linkedList2 != null)
            {
                linkedList2.Current.Next = temp;
            }
            linkedList1.Print();
            Console.WriteLine();
        }
    }
}
