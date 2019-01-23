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
        /// create stack with single node
        /// </summary>
        /// <param name="node">node</param>
        public Stack(Node node)
        {
            Top = node;
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
