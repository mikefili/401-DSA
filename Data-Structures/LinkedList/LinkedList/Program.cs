using Linked_List.classes;
using System;

namespace Linked_List
{
    public class Program
    {
        static void Main(string[] args)
        {
            ExampleList();
            Console.ReadLine();
        }

        /// <summary>
        /// generate example list with three nodes
        /// </summary>
        public static Object ExampleList()
        {
            LinkedList list = new LinkedList();
            list.Insert(5);
            list.Insert(10);
            list.Insert(15);
            list.Print();
            return list;
        }
    }
}
