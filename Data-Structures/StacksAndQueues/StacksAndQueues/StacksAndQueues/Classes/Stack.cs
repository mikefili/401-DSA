using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests_StacksAndQueues.Classes
{
    public class Stack
    {
        public Node Top { get; set; }

        /// <summary>
        /// Create a stack with at least one node in it
        /// </summary>
        /// <param name="node">node to be placed in stack</param>
        public Stack(Node node)
        {
            Top = node;
        }

        /// <summary>
        /// Create an empty stack
        /// </summary>
        public Stack()
        {

        }

        /// <summary>
        /// Create a new node with the provided value to the top of the stack
        /// </summary>
        /// <param name="val">value of node to be created</param>
        public void Push(int val)
        {
            Node node = new Node(val);
            node = Top;
        }

        /// <summary>
        /// Removes a node from the top of the stack and returns its value
        /// </summary>
        public int Pop()
        {

        }
    }
}
