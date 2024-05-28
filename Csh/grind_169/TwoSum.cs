using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.algo;

namespace ConsoleApp2.grind_169
{
    internal class TwoSum
    {
        private static int[] nums = { 2, 5, 5, 11 };
        private static int target = 10;
        public static int length = nums.Length;
        

        /// <summary>
        /// Finds the indices of two numbers in an array that add up to a target value using a brute-force approach.
        /// </summary>
        /// <param name="nums">The array of numbers to search through.</param>
        /// <param name="target">The target sum value.</param>
        /// <returns>An array containing the indices of the two numbers that add up to the target value, or an empty array if not found.</returns>
        public static int[] FindTwoSum(int[] nums, int target)
        {
            // Loop through the array to find two numbers that add up to the target
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    // If the sum of the two numbers equals the target, return their indices
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            // Return an empty array if no such pair is found
            return new int[] { };
        }

        public static int[] HashTable()
        {
            if (nums == null || nums.Length == 0)
            {
                return new int[] { };
            }

            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int currentValue = nums[i];
                int want = target - currentValue;
                if (dic.TryGetValue(want, out int value))
                {
                    return new int[] { value, i };
                }

                dic[currentValue] = i;
            }

            return new int[] { };
        }

        /// <summary>
        /// Finds the indices of two numbers that add up to a target value in an array.
        /// </summary>
        /// <param name="nums">The input array of numbers.</param>
        /// <param name="target">The target sum value.</param>
        /// <returns>An array containing the indices of the two numbers that add up to the target value, or an empty array if not found.</returns>
        public static int[] FindIndicesThatAddUpToTarget(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return new int[] { };
            }

            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int currentValue = nums[i];
                int want = target - currentValue;
                if (dic.TryGetValue(want, out int value))
                {
                    return new int[] { value, i };
                }

                dic[currentValue] = i;
            }

            return new int[] { };
        }

        /// <summary>
        /// Sorts the input array in ascending or descending order using bubble sort algorithm.
        /// </summary>
        /// <param name="order">The order in which to sort the array, either "asc" for ascending or "desc" for descending.</param>
        /// <returns>The sorted array.</returns>
        public static int[] Start(string order)
        {
            // Initialize the input array
            int[] arr = { 6, 3, 0, 5 };

            // Iterate through the array elements for sorting
            for (int i = 0; i < arr.Length - 1; i++)
            {
                // Iterate through the array elements for swapping
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    // Perform sorting based on the order
                    if (order == "asc")
                    {
                        Bubble_sort.Asc(ref arr, j);
                    }
                    else if (order == "desc")
                    {
                        Bubble_sort.Desc(ref arr, j);
                    }
                }
            }

            // Print the sorted array
            Bubble_sort.Print(order, arr);
            return arr;
        }
    }
}