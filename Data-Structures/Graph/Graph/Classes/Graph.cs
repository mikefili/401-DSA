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

        public Graph()
        {
            Nodes = new List<Node>();
        }

        // Add a node
        public Node AddNode(int value)
        {
            Node node = new Node(value);
            if (Nodes.Contains(node))
            {
                return null;
            }
            else
            {
                Nodes.Add(node);
                return node;
            }
        }

        // Add an edge
        public static void AddEdge(Node node)
        {
            node.Neighbors.Add(node);
        }
        
        // Get Nodes
        public List<Node> GetNodes()
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
