using System;
using HashTable.Classes;

namespace EC2_UniqueCharacterValidator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UniqueCharValidator(""));
            Console.ReadLine();
            Console.WriteLine(UniqueCharValidator("abcdefghijklmnopqrstuvwxyz"));
            Console.ReadLine();
            Console.WriteLine(UniqueCharValidator("this should fail"));
            Console.ReadLine();
        }

        /// <summary>
        /// Determines if a string is full of unique characters
        /// </summary>
        /// <param name="input">string to be checked</param>
        /// <returns>true if unique, false if not</returns>
        public static bool UniqueCharValidator(string input)
        {
            input = input.Replace(" ", "");
            Hashtable HT = new Hashtable(1024);

            for (int i = 0; i < input.Length; i++)
            {
                string character = Convert.ToString(input[i]);
                if (HT.Contains(character))
                {
                    return false;
                }
                HT.Add(character, character);
            }
            return true;
        }
    }
}
