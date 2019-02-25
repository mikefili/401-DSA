using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class Graph
    {
        // properties
        public List<Node> Nodes { get; }

        // Add a node
        public static Node AddNode(int value)
        {
            Node node = new Node(value);
            return node;
        }

        // Add an edge
        public static void AddEdge(Node front, Node rear)
        {

        }
        
        // Get Nodes


        // Get Neighbors

        
        // Get Size
    }
}
