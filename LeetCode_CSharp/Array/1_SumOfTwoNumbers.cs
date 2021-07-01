using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
 
    /// <summary>
    /// LeetCode 1.两数之和
    /// </summary>
    class SumOfTwoNumbers
    {
        /// <summary>
        /// 给定一个整数数组 nums 和一个整数目标值 target，请你在该数组中找出和为目标值 target 的那两个整数，并返回它们的数组下标。
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = i + 1; j < nums.Length; j++)
            //    {
            //        if (nums[i] + nums[j] == target)
            //        {
            //            return new int[] { i, j };
            //        }
            //    }
            //}
            //return null;


            //    Hashtable hashMap = new Hashtable();

            //    for (int i = 0; i < nums.Length; i++)
            //    {
            //        int temp = target - nums[i];
            //        if (hashMap.Contains(temp))
            //            return new int[] { (int)hashMap[temp], i };
            //        else
            //            hashMap.Add(nums[i], i);
            //    }

            //return null;


            var dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (dictionary.ContainsKey(complement))
                {
                    return new int[] { dictionary[complement], i };
                }

                dictionary[nums[i]] = i;
            }
            return null;

        }

    }
}
