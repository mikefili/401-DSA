using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        /// <summary>
        /// Instantiate a new node with a given value
        /// </summary>
        /// <param name="value">value to be assigned to new node</param>
        public Node(int value)
        {
            Value = value;
        }
    }
}
