using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class Node
    {
        public int Value { get; set; }

        /// <summary>
        /// instantiate empty node class
        /// </summary>
        public Node()
        {

        }

        /// <summary>
        /// instantiate node class w/ given value
        /// </summary>
        /// <param name="value">int value of new node class</param>
        public Node(int value)
        {
            Value = value;
        }
    }
}
