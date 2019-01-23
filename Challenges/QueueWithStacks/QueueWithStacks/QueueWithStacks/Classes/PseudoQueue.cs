using System;
using System.Collections;
using System.Collections.Generic;
using 
using System.Text;

namespace QueueWithStacks.Classes
{
    public class PseudoQueue
    {
        /// <summary>
        /// set Front and Rear properties
        /// </summary>
        public Stack Front { get; set; }
        public Stack Rear { get; set; }
        
    }

    /// <summary>
    /// create Stack class
    /// </summary>
    public class Stack
    {
        /// <summary>
        /// set Top property
        /// </summary>
        public Node Top { get; set; }

        /// <summary>
        /// instantiate a stack with a single node
        /// </summary>
        /// <param name="node">node</param>
        public Stack(Node node)
        {
            Top = node;
        }

        /// <summary>
        /// instantiate an empty stack
        /// </summary>
        public Stack()
        {

        }

        /// <summary>
        /// instantiate a new node on top of the stack
        /// </summary>
        /// <param name="value">value on new node</param>
        public void Push(int value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// "pop" top node off of stack
        /// </summary>
        /// <returns>top node</returns>
        public Node Pop()
        {
            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp;
        }
    }

    /// <summary>
    /// create Node class
    /// </summary>
    public class Node
    {
        /// <summary>
        /// set Value and Next properties
        /// </summary>
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
        }
    }
}
