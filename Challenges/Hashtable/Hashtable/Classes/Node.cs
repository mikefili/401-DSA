using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtable.Classes
{
    public class Node
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public string KeyValuePair { get; set; }

        /// <summary>
        /// Create a new Node with a key value pair
        /// </summary>
        /// <param name="key">Node's key string</param>
        /// <param name="value">Node's value string</param>
        public Node(string key, string value)
        {
            Key = key;
            Value = value;
            KeyValuePair = $"{key}:{value}";
        }
    }
}
