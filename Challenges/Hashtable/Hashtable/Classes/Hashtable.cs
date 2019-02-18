using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable.Classes
{
    public class Hashtable
    {
        public static Node[] HT { get; set; }

        public static int Buckets { get; set; }

        public Hashtable(int buckets)
        {
            Buckets = buckets;
            HT = new Node[Buckets];
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
            HT[hashedKey] = new Node(key, value);
        }

        public string Get(string key)
        {
            string value = "";
            return value;
        }

        public bool Contains(string key)
        {
            return false;
        }

        /// <summary>
        /// Takes in a key and returns its index in the node array
        /// </summary>
        /// <param name="key">key in key value pair</param>
        /// <returns>index in node array</returns>
        public static int Hash(string key)
        {
            int current = 0;
            for (int i = 0; i < key.Length; i++)
            {
                int charValue = Convert.ToInt32(key[i]);
                Console.Write($"{charValue} ");
                current += charValue;
                if (i == (key.Length - 1))
                {
                    Console.Write("= ");
                }
                else
                {
                    Console.Write("+ ");
                }
            }
            Console.WriteLine(current);

            int primeVal = current * 499;
            Console.WriteLine($"{current} * 499 = {primeVal}");

            int index = primeVal / Buckets;
            Console.WriteLine($"{primeVal} / {HT.Length} = {index}");

            Console.WriteLine($"Key gets placed in index of {index}");
            return index;
        }
    }
}
