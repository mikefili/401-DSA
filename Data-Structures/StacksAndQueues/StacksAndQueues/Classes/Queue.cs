using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        public Queue()
        {

        }

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
        public void Enqueue(Node node)
        {
            if (Front == null)
            {
                Front = node;
                Rear = node;
            }
            else
            {
                Rear.Next = node;
                Rear = node;
            }
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public Node Peek()
        {
            return Front;
        }
    }
}
