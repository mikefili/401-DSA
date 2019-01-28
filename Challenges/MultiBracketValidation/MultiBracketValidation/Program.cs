using System;

namespace MultiBracketValidation.Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input a bracket combination: ");
            string userInput = Console.ReadLine();
            Console.WriteLine(MultiBracketValidation(userInput));
        }

        /// <summary>
        /// Method takes in an input string and checks it for corresponding brackets
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool MultiBracketValidation(string input)
        {
            Stack stack = new Stack();

            // Iterate through input string
            for (int i = 0; i < input.Length; i++)
            {
                // Check input string for (, {, or [ bracket(s)
                if (input[i] == '(' || input[i] == '{' || input[i] == '[')
                {
                    stack.Push(input[i]);
                }
                // Check input string for corresponding ) brackets
                if (input[i] == ')')
                {
                    if (stack.Top != null && stack.Top.Value == '(')
                    {
                        stack.Pop();
                    }
                    else { return false; }
                }
                // Check input string for corresponding } brackets
                if (input[i] == '}')
                {
                    if (stack.Top != null && stack.Top.Value == '{')
                    {
                        stack.Pop();
                    }
                    else { return false; }
                }
                // Check input string for corresponding ] brackets
                if (input[i] == ']')
                {
                    if (stack.Top != null && stack.Top.Value == '[')
                    {
                        stack.Pop();
                    }
                    else { return false; }
                }
            }
            // If input given and no false returned yet, return true
            if (input == "")
            {
                Console.WriteLine("No Brackets Present");
                return false;
            }
            else if (stack.Top == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
