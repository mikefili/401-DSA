using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests_StacksAndQueues.Classes
{
    public class Stack
    {
        public Node Top { get; set; }

        public Stack(Node node)
        {
            Top = node;
        }

        public void Push(int val)
        {
            Node node = new Node(val);
            node = Top;
        }

        public void Pop()
        {

        }
    }
}
