using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    /*
        https://leetcode-cn.com/problems/sqrtx/
    */

    /// <summary>
    /// 69. x 的平方根
    /// </summary>
    class SqrtX
    {
        /// <summary>
        /// 算并返回 x 的平方根，其中 x 是非负整数。 
        /// 由于返回类型是整数，结果只保留整数的部分，小数部分将被舍去。
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int MySqrt(int x)
        {
            long i = 0;
            while (i * i <= x)
            {
                i++;
            }
            return (int)(i - 1);

            //return (int)Math.Sqrt(x);
            //return (int)Math.Pow(x, 0.5);
        }



        /// <summary>
        /// 
        /// 算并返回 x 的平方根，其中 x 是非负整数。 
        /// 由于返回类型是整数，结果只保留整数的部分，小数部分将被舍去。
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int MySqrt1(int x)
        {
            return (int)Math.Sqrt(x);
        }



        /// <summary>
        ///        
        /// 算并返回 x 的平方根，其中 x 是非负整数。 
        /// 由于返回类型是整数，结果只保留整数的部分，小数部分将被舍去。
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int MySqrt2(int x)
        {
            return (int)Math.Pow(x, 0.5);
        }



        /// <summary>
        ///        
        /// 算并返回 x 的平方根，其中 x 是非负整数。 
        /// 由于返回类型是整数，结果只保留整数的部分，小数部分将被舍去。
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int MySqrt3(int x)
        {
            return (int)Math.Pow(x, 0.5);
        }

    }
}
