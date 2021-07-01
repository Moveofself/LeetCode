using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    /*

     */


    /// <summary>
    /// LeetCode 9. 回文数
    /// </summary>
    class IsPalindromeNumber
    {
        /// <summary>
        /// 给你一个整数 x ，如果 x 是一个回文整数，返回 true ；否则，返回 false 。
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            int revertedNumber = 0;
            int temp = x;
            while (temp != 0)
            {
                revertedNumber = revertedNumber * 10 + temp % 10;
                temp /= 10;
            }

            return x == revertedNumber;
        }
    }
}
