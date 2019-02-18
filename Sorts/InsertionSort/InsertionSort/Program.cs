using System;

namespace InsertionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedArr = { 1, 5, 3 };
            InsertionSort(unsortedArr);

            int[] sortedArr = { 1, 3, 5 };
            InsertionSort(sortedArr);

            int[] backwardsArr = { 5, 3, 1 };
            InsertionSort(backwardsArr);

            int[] emptyArr = { };
            InsertionSort(emptyArr);

            int[] singleItemArr = { 1 };
            InsertionSort(singleItemArr);
        }

        public static int[] InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int n = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > n)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = n;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            return array;
        }
    }
}
