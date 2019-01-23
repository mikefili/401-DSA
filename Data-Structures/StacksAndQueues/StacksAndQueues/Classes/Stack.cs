using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
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
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// Removes a node from the top of the stack and returns its value
        /// </summary>
        public Node Pop()
        {
            try
            {
                Node temp = Top;
                Top = Top.Next;
                temp.Next = null;
                return temp;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        /// <summary>
        /// Returns the value of the node located on the top of the stack
        /// </summary>
        /// <returns>the value of Top</returns>
        public Node Peek()
        {
            return Top;
        }
    }
}
