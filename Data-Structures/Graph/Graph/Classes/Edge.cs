using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    public class Edge
    {
        public Node Origin { get; set; }
        public Node Next { get; set; }
        public int Weight { get; set; }

        public Edge(int weight)
        {
            Weight = weight;
        }
    }
}
