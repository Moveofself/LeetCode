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


                var output = SqrtX.MySqrt(int.Parse(input));
                
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
                int A =LargesTperimeterTriangle.LargestPerimeter(myArray);

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


        









        

        public static int 两路程之差()
        {
            return 0;
        }

        



        




    }
    
}
