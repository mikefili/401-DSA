using System;
using HashTable;
using HashTable.Classes;

namespace RepeatedWord
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static string RepeatedWord(string lengthyString)
        {
            Hashtable HT = new Hashtable(1024);

            string[] words = lengthyString.Split(null);
            foreach (string word in words)
            {
                string lowerWord = word.ToLower();
                if (HT.Contains(lowerWord) == true)
                {
                    Console.WriteLine($"The Repeated Word is: {lowerWord}");
                    return lowerWord;
                }
                else
                {
                    HT.Add(lowerWord, lowerWord);
                }
            }
            Console.WriteLine("No Repeated Words");
            return "No Repeated Words";
        }
    }
}
