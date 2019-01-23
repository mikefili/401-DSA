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
}
