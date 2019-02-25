using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable.Classes
{
    public class Hashtable
    {
        /// <summary>
        /// Properties
        /// </summary>
        public static Node[] HT { get; set; }

        /// <summary>
        /// Hashtable constructor
        /// </summary>
        /// <param name="buckets">Number of buckets in node array</param>
        public Hashtable(int buckets)
        {
            HT = new Node[buckets];
        }

        /// <summary>
        /// Creates a new Node in the node array that holds the key value pair
        /// at the index found by hashing the key
        /// </summary>
        /// <param name="key">Key value pair's key string</param>
        /// <param name="value">Key value pair's value string</param>
        public void Add(string key, string value)
        {
            int hashedKey = Hash(key);
            if (HT[hashedKey] == null)
            {
                HT[hashedKey] = new Node(key, value);
            }
            else
            {
                Node collision = HT[hashedKey];
                while (collision.Next != null)
                {
                    collision = collision.Next;
                }
                collision.Next = new Node(key, value);
            }
        }

        /// <summary>
        /// Takes in a key and returns its value from the node array
        /// </summary>
        /// <param name="key">Key value pair's key string</param>
        /// <returns>Key value pair's value string</returns>
        public string Get(string key)
        {
            string value = "";
            int hashedKey = Hash(key);
            if (Contains(key) == false)
            {
                return null;
            }
            else if (HT[hashedKey].Key == key)
            {
                value = HT[hashedKey].Value;
            }
            return value;
        }

        /// <summary>
        /// Takes in a key and returns true if it already exists in the table
        /// </summary>
        /// <param name="key">Key value pair's key string</param>
        /// <returns>true if key exists, else false</returns>
        public bool Contains(string key)
        {
            int hashedKey = Hash(key);
            if (HT[hashedKey] == null)
            {
                return false;
            }
            else
            {
                if (HT[hashedKey].Key == key)
                {
                    return true;
                }
                Node temp = HT[hashedKey];
                while (temp.Next != null)
                {
                    temp = temp.Next;
                    if (temp.Key == key)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Takes in a key and returns its index in the node array
        /// </summary>
        /// <param name="key">Key value pair's key string</param>
        /// <returns>index in node array</returns>
        public static int Hash(string key)
        {
            int index = 0;
            for (int i = 0; i < key.Length; i++)
            {
                index += Convert.ToInt32(key[i]);
            }
            index = (index * 499) / HT.Length;
            return index;
        }
    }
}
