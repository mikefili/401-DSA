using System;
using HashTable;
using HashTable.Classes;

namespace RepeatedWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            RepeatedWord("It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...");

            RepeatedWord("There are no repeats in this string.");
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
