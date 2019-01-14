using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List.classes
{
    public class Node
    {
        // property
        public int Value { get; set; }

        // property
        public Node Next { get; set; }

        // constructor
        public Node(int value)
        {
            Value = value;
        }
    }
}
