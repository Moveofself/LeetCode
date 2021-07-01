using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{

    /*
        https://leetcode-cn.com/problems/largest-perimeter-triangle/
     */

    /// <summary>
    /// 976. 三角形的最大周长
    /// </summary>
    class LargesTperimeterTriangle
    {   
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int LargestPerimeter(int[] nums)
        {
            Array.Sort(nums, (a, b) => b - a);
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i + 1] + nums[i + 2] > nums[i])
                {
                    return nums[i] + nums[i + 1] + nums[i + 2];
                }
            }

            return 0;
        }

    }
}
