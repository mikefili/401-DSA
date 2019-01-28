using System;
using System.Collections.Generic;
using System.Text;

namespace MultiBracketValidation.Classes
{
    class Node
    {
        public char Value { get; set; }
        public Node Next { get; set; }

        /// <summary>
        /// sets value on node
        /// </summary>
        /// <param name="value">value to be assigned</param>
        public Node(char value)
        {
            Value = value;
        }
    }
}
