using Linked_List.classes;
using System;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleList();
        }

        static void ExampleList()
        {
            LinkedList list = new LinkedList();
            list.Insert(5);
            list.Insert(10);
            list.Insert(15);
            list.Print();
            
        }
    }
}
