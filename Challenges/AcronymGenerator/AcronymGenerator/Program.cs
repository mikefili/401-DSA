using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace AcronymGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            //["a", "for", "an", "and", "of", "or", "the", "to", "with"]
            Console.WriteLine(GenerateAcronym("The Federal Bureau of Investigation"));
            Console.WriteLine(GenerateAcronym("A a An an And and For for Of of Or or To to The the With with United States of America"));
            Console.WriteLine(GenerateAcronym(""));
            Console.ReadLine();
        }

        public static string GenerateAcronym(string input)
        {
            if (input != "")
            {
                var remove = new string[] { "A", "An", "And", "For", "Of", "Or", "To", "The", "With" };
                foreach (var item in remove)
                {
                    input = input.Replace(item, "");
                }
                char[] chars = input.Where(Char.IsUpper).ToArray();
                string acronym = new String(chars);
                return acronym;
            }
            else return null;
        }
    }
}
