using System;
using Linked_List.classes;

namespace ll_kth_from_end
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static int KthFromEnd(int k, LinkedList linkedList)
        {
            int counter = 0;
            linkedList.Current = linkedList.Head;
            while (linkedList.Current.Next != null)
            {
                linkedList.Current = linkedList.Current.Next;
                counter++;
            }
            linkedList.Current = linkedList.Head;
            try
            {
                for (int i = 0; i < counter - k; i++)
                {
                    linkedList.Current = linkedList.Current.Next;
                }
                return linkedList.Current.Value;
            }
            catch (Exception)
            {
                Console.Write("Exception");
                throw;
            }
        }
    }
}
