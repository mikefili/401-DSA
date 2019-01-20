using System;
using Linked_List;

namespace ll_kth_from_end
{
    public class ProgramKth
    {
        static void Main(string[] args)
        {
            
        }

        public static int KthFromEnd(int k, LinkedList linkedList)
        {
            int counter = 1;
            linkedList.Current = linkedList.Head;
            while (linkedList.Current.Next != null)
            {
                linkedList.Current = linkedList.Current.Next;
                counter++;
            }
            if (k > counter - 1)
            {
                throw new Exception();
            }
            counter -= k;

            linkedList.Current = linkedList.Head;
            while (counter > 1)
            {
                linkedList.Current = linkedList.Current.Next;
                counter--;
            }
            return linkedList.Current.Value;
        }
    }
}
