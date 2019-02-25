using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class Node
    {
        // properties
        public int Value { get; set; }
        public List<Node> Neighbors { get; set; }
        public bool Visited { get; set; } 
        public int Degrees { get; set; }
        public List<Edge> Edges { get; set; }

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
            Visited = false;
            Neighbors = new List<Node>();
            Degrees = Neighbors.Count;
        }
    }
}
