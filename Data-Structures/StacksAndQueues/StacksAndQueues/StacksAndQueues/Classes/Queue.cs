using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        /// <summary>
        /// Instantiate a new queue with a front & read node
        /// </summary>
        /// <param name="node">node</param>
        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }

        /// <summary>
        /// Add a new node with a given value to the queue
        /// </summary>
        /// <param name="val">value of node to be added</param>
        public void Enqueue(int val)
        {
            Node node = new Node(val);
            Rear.Next = node;
            Rear = node;
        }

        public Node Dequeue()
        {
            try
            {
                Node temp = Front;
                Front = Front.Next;
                temp.Next = null;
                return temp;
            }
            catch (Exception)
            {
                Console.WriteLine("There was an exception!");
                throw;
            }
        }

        public Node Peek()
        {
            return Front;
        }
    }
}
