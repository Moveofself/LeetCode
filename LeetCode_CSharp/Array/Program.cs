using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Arrays
{
    class Program
    {

        public record Person(string FirstName, string LastName, string[] PhoneNumbers);

        public static void Show()
        {
            var phoneNumbers = new string[2];
            Person person1 = new("Nancy", "Davolio", phoneNumbers);
            Person person2 = person1 with { };
            Console.WriteLine(person1 == person2); // output: True

            person1.PhoneNumbers[0] = "555-1234";
            Console.WriteLine(person1 == person2); // output: True

            Console.WriteLine(person1.GetType());
            Console.WriteLine(person2.GetType());
            Console.WriteLine(ReferenceEquals(person1, person2)); // output: False
        }
        static void Main(string[] args)
        {
            //Show();
            bool Run = true;
            while (Run)
            {
                int[] a = new int[] { 2, 7, 11, 15 };

                Console.Write("请输入：");
                int m = 0;
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("输入为空，请重新输入!");
                    continue;
                }
                else
                {
                    if (input.ToUpper() == "N")
                    {
                        Console.WriteLine("准备退出!");
                        break;
                    }
                    //else if (!int.TryParse(input, out i))
                    //{
                    //    Console.WriteLine("输入格式错误，请重新输入!");
                    //    continue;
                    //}

                }


                Stopwatch sw = new Stopwatch();
                //启动计时
                sw.Start();
                //var output = "";
                //var aa = TwoSum(a, 9);
                //for (int i = 0; i < aa.Length; i++)
                //{
                //    Console.WriteLine(aa[i]);
                //}

                //var output = Reverse(int.Parse(input));

                //var output=IsPalindrome(int.Parse(input));

                //if (!Function(input))
                //{
                //    continue;
                //}


                var output = MySqrt(int.Parse(input));

                int[] nums = new int[] {1,3,2,3,4,5,2};
                //int n=2;
                //int len=removeElement(nums,n);
                //for (int i = 0; i < len; i++)
                //{
                //    Console.WriteLine(nums[i]);
                //}

                int [] aaa=SumOfTwoNumbers.TwoSum(nums,8);


                //var output = RomanToInt(input);

                //关闭计时
                sw.Stop();

                Console.WriteLine("运行结果: " + output);

                //输出时间(单位:毫秒)
                Console.WriteLine(sw.Elapsed.TotalMilliseconds.ToString());

                Console.WriteLine(sw.ElapsedTicks);

            }

            Console.ReadKey();

        }

        static bool Function(string sTemp)
        {
            try
            {
                string[] strArray = sTemp.Split(' ');
                int[] myArray = Array.ConvertAll(strArray, int.Parse);
                int A = LargestPerimeter(myArray);

                Console.WriteLine("周长为：" + A);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("出现错误，请重新执行！");
                return false;
            }

        }


        private static int LargestPerimeter(int[] nums)
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





        /// <summary>
        /// LeetCode 7. 整数反转
        /// 给你一个 32 位的有符号整数 x ，返回将 x 中的数字部分反转后的结果。
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



        /// <summary>
        /// LeetCode 9. 回文数
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

        public static int 两路程之差()
        {
            return 0;
        }

        /// <summary>
        /// LeetCode 13. 罗马数字转整数
        /// https://leetcode-cn.com/problems/roman-to-integer/
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



        /// <summary>
        /// LeetCode 69. x 的平方根
        /// 算并返回 x 的平方根，其中 x 是非负整数。 
        /// 由于返回类型是整数，结果只保留整数的部分，小数部分将被舍去。
        /// https://leetcode-cn.com/problems/sqrtx/
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int MySqrt(int x)
        {
            long i=0;
            while (i*i<=x)
            {
                i++;
            }
            return (int)(i - 1);

            //return (int)Math.Sqrt(x);
            //return (int)Math.Pow(x, 0.5);
        }




    }
    
}
