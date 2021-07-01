using System;
using System.Diagnostics;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
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


                int iCount = 5;


                string[] A=GetNumber();
                foreach (var item in A)
                {
                    Console.Write(item + " ");
                }

                GetNumber(5);


                //var output = 0;


                //关闭计时
                sw.Stop();

                //Console.WriteLine("运行结果: " + output);

                //输出时间(单位:毫秒)
                Console.WriteLine(sw.Elapsed.TotalMilliseconds.ToString());

                Console.WriteLine(sw.ElapsedTicks);

            }
            Console.ReadKey();
        }


        public static string[] GetNumber()
        {
            string[] array = new string[7];
            Random rd = new Random();

            array[0] = rd.Next(1, 34).ToString("00");
            do
            {
                array[1] = rd.Next(1, 34).ToString("00");
            } while (array[1] == array[0]);

            do
            {
                array[2] = rd.Next(1, 34).ToString("00");
            } while (array[2] == array[0] || array[2] == array[1]);

            do
            {
                array[3] = rd.Next(1, 34).ToString("00");
            } while (array[3] == array[0] || array[3] == array[1] || array[3] == array[2]);

            do
            {
                array[4] = rd.Next(1, 34).ToString("00");
            } while (array[4] == array[0] || array[4] == array[1] || array[4] == array[2] || array[4] == array[3]);
            
            do
            {
                array[5] = rd.Next(1, 34).ToString("00");
            } while (array[5] == array[0] || array[5] == array[1] || array[5] == array[2] || array[5] == array[3] || array[5] == array[4]);

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length - 1; j++)
                {
                    if (Convert.ToInt32(array[i]) > Convert.ToInt32(array[j]))
                    {
                        string temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            array[6] = rd.Next(1, 17).ToString("00");

            return array;
        }


        private static void GetNumber(int iCount=10,int iRedCout=6,int iBlueCout=1)
        {
            string[] strRed = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33" };
            string[] strBlue = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16" };
            int intCount = iCount;//组数
            int intRedCount = iRedCout;//红球数
            int intBlueCount = iBlueCout;//蓝球数
            Random rd = new Random();
            for (int i = 1; i <= intCount; i++)
            {
                //红球
                string tempRed = "";
                string[] arrRed = new string[intRedCount];
                int r = 0;
                for (int j = 0; j < strRed.Length; j++)
                {
                    string s = strRed[rd.Next(0, strRed.Length)];
                    if (tempRed.IndexOf(s) == -1)//是否已存在重复红球
                    {
                        tempRed += s + " ";
                        arrRed[r] = s;
                        r++;
                    }
                    if (r == intRedCount)
                    {
                        break;
                    }
                }

                //蓝球
                string tempBlue = "";
                string[] arrBlue = new string[intBlueCount];
                int b = 0;
                for (int j = 0; j < strBlue.Length; j++)
                {
                    string s = strBlue[rd.Next(0, strBlue.Length)];
                    if (tempBlue.IndexOf(s) == -1)//是否已存在重复蓝球
                    {
                        tempBlue += s + " ";
                        arrBlue[b] = s;
                        b++;
                    }
                    if (b == intBlueCount)
                    {
                        break;
                    }
                }

                //排序(由小到大排序)
                for (int m = 0; m < arrRed.Length; m++)
                {
                    string tempstr;
                    for (int mm = m + 1; mm < arrRed.Length; mm++)
                    {
                        if (Convert.ToInt32(arrRed[m]) > Convert.ToInt32(arrRed[mm]))
                        {
                            tempstr = arrRed[m];
                            arrRed[m] = arrRed[mm];
                            arrRed[mm] = tempstr;
                        }
                    }
                }
                for (int m = 0; m < arrBlue.Length; m++)
                {
                    string tempstr;
                    for (int mm = m + 1; mm < arrBlue.Length; mm++)
                    {
                        if (Convert.ToInt32(arrBlue[m]) > Convert.ToInt32(arrBlue[mm]))
                        {
                            tempstr = arrBlue[m];
                            arrBlue[m] = arrBlue[mm];
                            arrBlue[mm] = tempstr;
                        }
                    }
                }

                //取数据
                string tempR = "", tempB = "";
                for (int j = 0; j < arrRed.Length; j++)
                {
                    tempR += arrRed[j];
                    if (j != arrRed.Length - 1)
                        tempR += " ";
                }
                for (int j = 0; j < arrBlue.Length; j++)
                {
                    tempB += arrBlue[j];
                    if (j != arrBlue.Length - 1)
                        tempB += " ";
                }

                //计算金额
                long p1 = 1; ;
                for (int j = 1; j <= arrRed.Length; j++)
                {
                    p1 *= (arrRed.Length - j + 1);
                }
                long p2 = 1; ;
                for (int j = 1; j <= 6; j++)
                {
                    p2 *= j;//6!=6*5*4*3*2*1
                }
                long p3 = 1; ;
                for (int j = 1; j <= (arrRed.Length - 6); j++)
                {
                    p3 *= (arrRed.Length - 6 - j + 1);
                }
                long pR = p1 / (p2 * p3);
                long pB = arrBlue.Length;
                Console.WriteLine(tempR + ":" + tempB + " (" + Convert.ToString(pR * pB) + "注  共" + Convert.ToString(pR * pB * 2) + "元)");
            }
        }
    }
}
