using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    /*
     * https://leetcode-cn.com/problems/roman-to-integer/
     */

    /// <summary>
    /// LeetCode 13. 罗马数字转整数
    /// </summary>
    class RomanToInteger
    {
        /// <summary>
        /// 罗马数字转整数
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int RomanToInt(string s)
        {
            s = s.ToUpper();

            int SUM = 0;
            Dictionary<char, int> dictionary = new Dictionary<char, int>()
            {
                { 'I', 1},
                {'V', 5 },
                {'X', 10 },
                {'L', 50 },
                {'C', 100 },
                {'D', 500 },
                {'M', 1000 }
            };

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (dictionary[s[i]] < dictionary[s[i + 1]])
                {
                    SUM -= dictionary[s[i]];
                }
                else
                {
                    SUM += dictionary[s[i]];
                }

            }

            return SUM + dictionary[s[s.Length - 1]];
        }
    }
}
