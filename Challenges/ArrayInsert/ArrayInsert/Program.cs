using System;

namespace ArrayShift
{
    public class Program
    {
        // declare Main method
        static void Main(string[] args)
        {
            // declare and populate initial array
            int[] array = { 2, 4, 6, 8 };
            // iterate through initial array to console
            Console.Write("Current Array: [");
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write($"{array[i]},");
            }
            Console.Write($"{array[array.Length - 1]}");
            Console.WriteLine("]");

            // request additional int from user to insert into array
            Console.Write("Please provide an additional number: ");
            int value = Convert.ToInt32(Console.ReadLine());
            // call ArrayShift method and return newArr including new value
            int[] newArr = ArrayShift(array, value);

            //iterate through newArr and write each index
            Console.Write("New Array: [");
            for (int i = 0; i < newArr.Length - 1; i++)
            {
                Console.Write($"{newArr[i]},");
            }
            Console.Write($"{newArr[newArr.Length - 1]}");
            Console.Write("]");
            Console.ReadLine();
        }

        // declare ArrayShift method
        public static int[] ArrayShift(int[] array, int val)
        {
            int[] newArr = new int[array.Length + 1];

            // find midpoint of array with even amount of indexes and return newArr
            if (array.Length % 2 == 0)
            {
                int midPointIndex = array.Length * 1 / 2;

                for (int i = 0; i < newArr.Length; i++)
                {
                    if (i < midPointIndex)
                    {
                        newArr[i] = array[i];
                    }
                    else if (i == midPointIndex)
                    {
                        newArr[i] = val;
                    }
                    else
                    {
                        newArr[i] = array[i - 1];
                    }
                }
                return newArr;
            }
            // find midpoint of array with odd amount of indexes and return newArr
            else
            {
                int midPointIndex = (array.Length+1 * 1 / 2);

                for (int i = 0; i < newArr.Length; i++)
                {
                    if (i < midPointIndex)
                    {
                        newArr[i] = array[i];
                    }
                    else if (i == midPointIndex)
                    {
                        newArr[i] = val;
                    }
                    else
                    {
                        newArr[i] = array[i - 1];
                    }
                }
                return newArr;
            }
        }
    }
}
