using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    /// <summary>
    /// 27.移除元素
    /// </summary>
    class RemoveElemet
    {
        /// <summary>
        /// 给你一个数组nums和一个值val，你需要原地移除所有数值等于val的元素，并返回移除后数组的新长度。
        /// https://leetcode-cn.com/problems/remove-element/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static int removeElement(int[] nums, int val)
        {
            int n = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[n] = nums[i];
                    n++;
                }
            }

            return n;
        }
    }
}
