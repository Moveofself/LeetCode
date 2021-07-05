using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace TestCode
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

                //string[] A=GetNumber();
                //foreach (var item in A)
                //{
                //    Console.Write(item + " ");
                //}
                //Console.WriteLine();


                string[] TargetRed = { "01", "06", "18", "22", "24", "25" };
                string[] TargetRed1 = { "04", "05", "09", "14", "25", "27" };
                string[] TargetBlue = { "08" };
                string[] TargetBlue1 = { "07" };
                double i = 0;
                //while (!CompareArray(Final,GetNumber(1)))
                //{
                //    i++;
                //}



                string st1 = "17:00";
                DateTime dt1 = Convert.ToDateTime(st1);

                DateTime dt2 = DateTime.Now;

                for (int j = 0; j < 10; j++)
                {
                    CaiPiao Ball = new CaiPiao
                    {
                        title = "",
                        TotalRedBall = 33,
                        ChooseRedBall = 6,
                        TotalBlueBall = 16,
                        ChooseBlueBall = 1,
                        RedBall = new string[6],
                        BlueBall = new string[1],
                        TotalBall = new string[7],
                        Level1 = 0,
                        Level2 = 0,
                        Level3 = 0,
                        Level4 = 0,
                        Level5 = 0,
                        Level6 = 0,
                        TotalCount = 0
                    };

                    do
                    {
                        BallNumber.MainProcess(ref Ball, TargetRed, TargetBlue);

                        //Function.WriteToExcel("111", Ball.TotalBall);
                    } while (Ball.Level1 < 1);

                    string tempR = string.Empty, tempB = string.Empty;
                    for (int m = 0; m < Ball.RedBall.Length; m++)
                    {
                        tempR += Ball.RedBall[m];
                        if (m != Ball.RedBall.Length - 1)
                            tempR += " ";
                    }


                    for (int n = 0; n < Ball.BlueBall.Length; n++)
                    {
                        tempB += Ball.BlueBall[n];
                        if (n != Ball.BlueBall.Length - 1)
                            tempB += " ";
                    }


                    Log.WriteLog("第一期 " + tempR + ":" + tempB+" 总注数："+ Ball.TotalCount);
                    Log.WriteLog("中1等奖共" + Ball.Level1.ToString() + "注，概率为：" + (Convert.ToDecimal(Ball.Level1) / Convert.ToDecimal(Ball.TotalCount) * 100).ToString() + "%");
                    Log.WriteLog("中2等奖共" + Ball.Level2.ToString() + "注，概率为：" + (Convert.ToDecimal(Ball.Level2) / Convert.ToDecimal(Ball.TotalCount) * 100).ToString() + "%");
                    Log.WriteLog("中3等奖共" + Ball.Level3.ToString() + "注，概率为：" + (Convert.ToDecimal(Ball.Level3) / Convert.ToDecimal(Ball.TotalCount) * 100).ToString() + "%");
                    Log.WriteLog("中4等奖共" + Ball.Level4.ToString() + "注，概率为：" + (Convert.ToDecimal(Ball.Level4) / Convert.ToDecimal(Ball.TotalCount) * 100).ToString() + "%");
                    Log.WriteLog("中5等奖共" + Ball.Level5.ToString() + "注，概率为：" + (Convert.ToDecimal(Ball.Level5) / Convert.ToDecimal(Ball.TotalCount) * 100).ToString() + "%");
                    Log.WriteLog("中6等奖共" + Ball.Level6.ToString() + "注，概率为：" + (Convert.ToDecimal(Ball.Level6) / Convert.ToDecimal(Ball.TotalCount) * 100).ToString() + "%");

                }


                for (int j = 0; j < 10; j++)
                {
                    CaiPiao Ball = new CaiPiao
                    {
                        title = "",
                        TotalRedBall = 33,
                        ChooseRedBall = 6,
                        TotalBlueBall = 16,
                        ChooseBlueBall = 1,
                        RedBall = new string[6],
                        BlueBall = new string[1],
                        TotalBall = new string[7],
                        Level1 = 0,
                        Level2 = 0,
                        Level3 = 0,
                        Level4 = 0,
                        Level5 = 0,
                        Level6 = 0,
                        TotalCount = 0
                    };

                    do
                    {
                        BallNumber.MainProcess(ref Ball, TargetRed1, TargetBlue1);

                        //Function.WriteToExcel("111", Ball.TotalBall);
                    } while (Ball.Level1 < 1);

                    string tempR = string.Empty, tempB = string.Empty;
                    for (int m = 0; m < Ball.RedBall.Length; m++)
                    {
                        tempR += Ball.RedBall[m];
                        if (m != Ball.RedBall.Length - 1)
                            tempR += " ";
                    }


                    for (int n = 0; n < Ball.BlueBall.Length; n++)
                    {
                        tempB += Ball.BlueBall[n];
                        if (n != Ball.BlueBall.Length - 1)
                            tempB += " ";
                    }

                    Log.WriteLog("第二期 " + tempR + ":" + tempB + " 总注数：" + Ball.TotalCount);
                    Log.WriteLog("中1等奖共" + Ball.Level1.ToString() + "注，概率为：" + (Convert.ToDecimal(Ball.Level1) / Convert.ToDecimal(Ball.TotalCount) * 100).ToString() + "%");
                    Log.WriteLog("中2等奖共" + Ball.Level2.ToString() + "注，概率为：" + (Convert.ToDecimal(Ball.Level2) / Convert.ToDecimal(Ball.TotalCount) * 100).ToString() + "%");
                    Log.WriteLog("中3等奖共" + Ball.Level3.ToString() + "注，概率为：" + (Convert.ToDecimal(Ball.Level3) / Convert.ToDecimal(Ball.TotalCount) * 100).ToString() + "%");
                    Log.WriteLog("中4等奖共" + Ball.Level4.ToString() + "注，概率为：" + (Convert.ToDecimal(Ball.Level4) / Convert.ToDecimal(Ball.TotalCount) * 100).ToString() + "%");
                    Log.WriteLog("中5等奖共" + Ball.Level5.ToString() + "注，概率为：" + (Convert.ToDecimal(Ball.Level5) / Convert.ToDecimal(Ball.TotalCount) * 100).ToString() + "%");
                    Log.WriteLog("中6等奖共" + Ball.Level6.ToString() + "注，概率为：" + (Convert.ToDecimal(Ball.Level6) / Convert.ToDecimal(Ball.TotalCount) * 100).ToString() + "%");

                }

                //while (BallNumber.MainProcess(ref Ball, TargetRed, TargetBlue) != 1)
                //{

                //}

                //Console.WriteLine("中1等奖共" + Ball.Level1.ToString() + "注，概率为：" + (Convert.ToDecimal(Ball.Level1) / Convert.ToDecimal(Ball.TotalCount) * 100).ToString() + "%");
                //Console.WriteLine("中2等奖共" + Ball.Level2.ToString() + "注，概率为：" + (Convert.ToDecimal(Ball.Level2) / Convert.ToDecimal(Ball.TotalCount) * 100).ToString() + "%");
                //Console.WriteLine("中3等奖共" + Ball.Level3.ToString() + "注，概率为：" + (Convert.ToDecimal(Ball.Level3) / Convert.ToDecimal(Ball.TotalCount) * 100).ToString() + "%");
                //Console.WriteLine("中4等奖共" + Ball.Level4.ToString() + "注，概率为：" + (Convert.ToDecimal(Ball.Level4) / Convert.ToDecimal(Ball.TotalCount) * 100).ToString() + "%");
                //Console.WriteLine("中5等奖共" + Ball.Level5.ToString() + "注，概率为：" + (Convert.ToDecimal(Ball.Level5) / Convert.ToDecimal(Ball.TotalCount) * 100).ToString() + "%");
                //Console.WriteLine("中6等奖共" + Ball.Level6.ToString() + "注，概率为：" + (Convert.ToDecimal(Ball.Level6) / Convert.ToDecimal(Ball.TotalCount) * 100).ToString() + "%");


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


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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



        /// <summary>
        /// 
        /// </summary>
        /// <param name="iCount"></param>
        /// <param name="iRedCout"></param>
        /// <param name="iBlueCout"></param>
        /// <returns></returns>
        private static string[] GetNumber(int iCount = 10, int iRedCout = 6, int iBlueCout = 1)
        {
            string[] strRed = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33" };
            string[] strBlue = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16" };
            int intCount = iCount;//组数
            int intRedCount = iRedCout;//红球数
            int intBlueCount = iBlueCout;//蓝球数
            string[] Result = new string[iRedCout + iBlueCout];
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
                    Result[j] = arrRed[j];
                    if (j != arrRed.Length - 1)
                        tempR += " ";
                }


                for (int j = 0; j < arrBlue.Length; j++)
                {
                    tempB += arrBlue[j];
                    Result[arrRed.Length + j] = arrBlue[j];
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
            return Result;
        }



        /// <summary>
        /// 数组比较是否相等
        /// </summary>
        /// <param name="s1">数组1</param>
        /// <param name="s2">数组2</param>
        /// <returns>true:相等，false:不相等</returns>
        public static bool CompareArray(string[] s1, string[] s2)
        {
            var len1 = s1.Length;
            var len2 = s2.Length;
            if (len1 != len2)
            {
                return false;
            }
            for (var i = 0; i < len1; i++)
            {
                if (s1[i] != s2[i])
                    return false;
            }
            return true;
        }





    }

    struct CaiPiao
    {
        public string title;
        public int TotalRedBall;
        public int ChooseRedBall;
        public int TotalBlueBall;
        public int ChooseBlueBall;
        public string[] RedBall;
        public string[] BlueBall;
        public string[] TotalBall;
        public int Level1;
        public int Level2;
        public int Level3;
        public int Level4;
        public int Level5;
        public int Level6;
        public int TotalCount;
    };

    class BallNumber
    {
        /// <summary>
        /// 彩票生成及计算主程序
        /// </summary>
        /// <param name="Ball">彩票实体</param>
        /// <param name="Target">目标结果</param>
        public static int MainProcess(ref CaiPiao Ball, string[] TargetRed, string[] TargetBlue)
        {

            Ball.RedBall = GenerateBallNumber(Ball.ChooseRedBall, Ball.TotalRedBall);
            Ball.BlueBall = GenerateBallNumber(Ball.ChooseBlueBall, Ball.TotalBlueBall);
            int Level = CompareArray(ref Ball, TargetRed, TargetBlue);
            PrintInfo(Ball, Level);
            return Level;

        }


        /// <summary>
        /// 产生随机不重复数组
        /// </summary>
        /// <param name="iCount"></param>
        /// <param name="MAX"></param>
        /// <returns></returns>
        public static string[] GenerateBallNumber(int iCount = 6, int MAX = 33)
        {
            byte[] buffer = Guid.NewGuid().ToByteArray(); 
            int iSeed = BitConverter.ToInt32(buffer, 0); 

            bool bRun = true;
            Random rd = new Random(iSeed);
            int temp = 0, i = 0;
            int[] tempArr = new int[iCount];
            string s = string.Empty;
            do
            {
                temp = rd.Next(1, MAX + 1);
                if (Array.IndexOf(tempArr, temp) < 0)//是否已存在重复
                {
                    tempArr[i] = temp;
                    i++;
                }
                if (i == iCount)
                {
                    break;

                }

            } while (bRun);


            return tempArr.Select(o => o.ToString("00")).ToArray();
        }


        /// <summary>
        /// 数组比较是否相等
        /// </summary>
        /// <param name="s1">数组1</param>
        /// <param name="s2">数组2</param>
        /// <returns>true:相等，false:不相等</returns>
        public static int CompareArray(ref CaiPiao Ball, string[] TargetRed, string[] TargetBlue)
        {
            string[] Red = Ball.RedBall;
            string[] Blue = Ball.BlueBall;
            Ball.TotalCount++;

            if (Red.Length != TargetRed.Length && Blue.Length != TargetBlue.Length)
            {
                return 0;
            }

            //判断蓝球是否相等
            bool bRule = true;
            for (int i = 0; i < Blue.Length; i++)
            {
                if (Blue[i] != TargetBlue[i])
                    bRule = false;
            }

            string[] temp = TargetRed.Intersect(Red).ToArray();

            int m = temp.Length;

            if (m == 6 && bRule)
            {
                Ball.Level1++;
                return 1;
            }
            else if (m == 6 && !bRule)
            {
                Ball.Level2++;
                return 2;
            }
            else if (m == 5 && bRule)
            {
                Ball.Level3++;
                return 3;
            }
            else if ((m == 5 && !bRule) || (m == 4 && bRule))
            {
                Ball.Level4++;
                return 4;
            }
            else if ((m == 4 && !bRule) || (m == 3 && bRule))
            {
                Ball.Level5++;
                return 5;
            }
            else if ((m == 2 && bRule) || (m == 1 && bRule) || bRule)
            {
                Ball.Level6++;
                return 6;
            }
            else
            {
                return 0;
            }

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="Red"></param>
        /// <param name="Blue"></param>
        /// <param name="Level"></param>
        public static void PrintInfo(CaiPiao Ball, int Level)
        {
            string[] Red = Ball.RedBall;
            string[] Blue = Ball.BlueBall;
            //排序(由小到大排序)
            for (int m = 0; m < Red.Length; m++)
            {
                string tempstr;
                for (int mm = m + 1; mm < Red.Length; mm++)
                {
                    if (Convert.ToInt32(Red[m]) > Convert.ToInt32(Red[mm]))
                    {
                        tempstr = Red[m];
                        Red[m] = Red[mm];
                        Red[mm] = tempstr;
                    }
                }
            }
            for (int m = 0; m < Blue.Length; m++)
            {
                string tempstr;
                for (int mm = m + 1; mm < Blue.Length; mm++)
                {
                    if (Convert.ToInt32(Blue[m]) > Convert.ToInt32(Blue[mm]))
                    {
                        tempstr = Blue[m];
                        Blue[m] = Blue[mm];
                        Blue[mm] = tempstr;
                    }
                }
            }

            Ball.RedBall = Red;
            Ball.BlueBall = Blue;

            //取数据
            string tempR = "", tempB = "";
            for (int j = 0; j < Red.Length; j++)
            {
                tempR += Red[j];
                if (j != Red.Length - 1)
                    tempR += " ";
            }


            for (int j = 0; j < Blue.Length; j++)
            {
                tempB += Blue[j];
                if (j != Blue.Length - 1)
                    tempB += " ";
            }

            Red.CopyTo(Ball.TotalBall, 0);
            Blue.CopyTo(Ball.TotalBall, Red.Length);

            if (Level > 0)
            {
                Console.WriteLine(tempR + ":" + tempB + " (中" + Convert.ToString(Level) + "等奖！ 共" + Ball.TotalCount + "注)");
            }
            else
            {
                Console.WriteLine(tempR + ":" + tempB + " (" + "未中奖！ 共" + Ball.TotalCount + "注)");
            }


        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="iCount"></param>
        /// <param name="iRedCout"></param>
        /// <param name="iBlueCout"></param>
        /// <returns></returns>
        public static void GetAllNumber(out string[] arrRed, out string[] arrBlue, int intCount = 10, int intRedCount = 6, int intBlueCount = 1)
        {
            string[] strRed = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33" };
            string[] strBlue = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16" };
            string[] Result = new string[intRedCount + intBlueCount];
            Random rd = new Random();
            arrRed = new string[intRedCount];
            arrBlue = new string[intBlueCount];
            for (int i = 1; i <= intCount; i++)
            {
                //红球
                string tempRed = "";

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


                //计算金额
                //long p1 = 1; ;
                //for (int j = 1; j <= arrRed.Length; j++)
                //{
                //    p1 *= (arrRed.Length - j + 1);
                //}
                //long p2 = 1; ;
                //for (int j = 1; j <= 6; j++)
                //{
                //    p2 *= j;//6!=6*5*4*3*2*1
                //}
                //long p3 = 1; ;
                //for (int j = 1; j <= (arrRed.Length - 6); j++)
                //{
                //    p3 *= (arrRed.Length - 6 - j + 1);
                //}

                //long pR = p1 / (p2 * p3);
                //long pB = arrBlue.Length;


            }
        }


    }
}
