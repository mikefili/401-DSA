using System;
using System.Collections.Generic;
using System.Linq;
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
        public static List<Node> GetNodes()
        {
            List<Node> nodes = new List<Node>();
            return nodes;
        }

        // Get Neighbors
        public static List<Node> GetNeighbors(Node node)
        {
            return node.Neighbors;
        }
        
        // Get Size
        public int Size(Graph graph)
        {
            return Nodes.Count();
        }
    }
}
