using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 8, 15, 16, 23, 42 };
            int key = 15;

            int index = BinarySearch(nums, key);
            Console.WriteLine(index);
        }

        public static int BinarySearch(int[] arr, int key)
        {
            // declare two indexes which are left and right
            int leftIndex = 0;
            int rightIndedx = arr.Length - 1;

            // keep left index on the left or the same position to the right index
            while (leftIndex <= rightIndedx)
            {
                //declare the middle point
                int middle = (leftIndex + rightIndedx) / 2;
                //if the key is the same with the value at the middle point return middle index 
                if (key == arr[middle])
                {
                    return middle;
                }
                //if key is larger than the value of the middle point ,move the left index to the right one more index  to the middle point
                else if (key > arr[middle])
                {
                    leftIndex = middle + 1;
                }
                //if key is smaller than the value of the middle point, move the right index to the left one more index to the middle point
                else
                {
                    rightIndedx = middle - 1;
                }
            }

            //after while loop not found ,return -1
            return -1;
        }
    }
}
