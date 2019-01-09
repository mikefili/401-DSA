using System;

namespace ArrayShift
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 4, 6, 8 };
            Console.Write("Current Array: [");
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write($"{array[i]},");
            }
            Console.Write($"{array[array.Length - 1]}");
            Console.WriteLine("]");

            Console.Write("Please provide an additional number: ");
            int val = Convert.ToInt32(Console.ReadLine());
            //call ArrayShift function then return a new array
            int[] newArr = ArrayShift(array, val);

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

        public static int[] ArrayShift(int[] array, int val)
        {
            int[] newArr = new int[array.Length + 1];

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
