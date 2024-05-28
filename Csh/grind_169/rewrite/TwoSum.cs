using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshAlgo.grind_169.rewrite
{


    public class TwoSum
    {
        private readonly int[] arr1 = { 2, 2, 1 };
        private readonly int[] arr2 = { 4, 1, 2, 1, 2 };
        private readonly int[] arr3 = { 2, 7, 11, 15 };
        private readonly int target = 9;

        public void  Start()
        {
            int[] res = brute(arr3, target);
            Console.WriteLine("brute method:");
            foreach(int i in res)
            {
                Console.WriteLine(i);
            }

            res = hashtable(arr3, target);
            Console.WriteLine("hashtable method:");
            foreach(int i in res)
            {
                Console.WriteLine(i);
            }
        }


        private int[] brute(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++) {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target) {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { };
        }

        private int[] hashtable(int[] nums, int target) {
            if (nums.Length == 0 || nums is null) {
                return new int[] { };
            }
            Dictionary<int,int> ht = new Dictionary<int,int>();

            for (int i = 0; i < nums.Length; i++) {
                int want = target - nums[i];
                int valueInDic;
                if (ht.TryGetValue(want, out valueInDic)) 
                {
                    return new int[] { valueInDic, i };
                }
                // add value, index to dictionary
                ht.Add(nums[i], i);
            }
            return new int[] { };
        }

    }
}
