using System;
using System.Collections.Generic;
using System.Text;

namespace MultiBracketValidation.Classes
{
    class Stack
    {
        public Node Top { get; set; }

        /// <summary>
        /// instantiate empty stack
        /// </summary>
        public Stack()
        {

        }

        /// <summary>
        /// instantiate stack with one node
        /// </summary>
        /// <param name="node">top node</param>
        public Stack(Node node)
        {
            Top = node;
        }

        /// <summary>
        /// "push" node onto the top of the stack
        /// </summary>
        /// <param name="value">top node value</param>
        public void Push(char value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// "pops" the top node off the stack
        /// </summary>
        /// <returns>top node</returns>
        public Node Pop()
        {
            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp;
        }

        /// <summary>
        /// "Peeks" at the top node of the stack
        /// </summary>
        /// <returns>top node</returns>
        public Node Peek()
        {
            return Top;
        }
    }
}
