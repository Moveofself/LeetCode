using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    /// <summary>
    /// LeetCode 7. 整数反转
    /// </summary>
    class ReverseNumber
    {
        /// <summary>
        /// 给你一个 32 位的有符号整数 x ，返回将 x 中的数字部分反转后的结果。
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int Reverse(int x)
        {
            int rev = 0;
            while (x != 0)
            {
                if (rev < int.MinValue / 10 || rev > int.MaxValue / 10)
                {
                    return 0;
                }
                int digit = x % 10;
                x /= 10;
                rev = rev * 10 + digit;
            }
            return rev;
        }
    }
}
