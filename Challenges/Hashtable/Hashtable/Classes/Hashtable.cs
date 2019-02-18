using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtable.Classes
{
    public class Hashtable
    {
        public Node[] HT { get; set; }

        public Hashtable()
        {
            
        }

        public void Add(string key, string value)
        {

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

        public static int Hash(string key)
        {
            int index = 0;
            for (int i = 0; i < key.Length; i++)
            {

                int charValue = (Encoding.ASCII.GetMaxByteCount(key[i]) - 1);
                Console.Write($"{charValue} ");
                index += charValue;
                if (i == (key.Length - 1))
                {
                    Console.Write("= ");
                }
                else
                {
                    Console.Write("+ ");
                }
            }
            Console.Write(index);
            return index;
        }
    }
}
