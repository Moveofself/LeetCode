﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Cells;

namespace TestCode
{
    class Function
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        public static void WriteToExcel(string Name, string[] Data)
        {
            string sPath = Environment.CurrentDirectory;
            string sFilePath = Path.Combine(Environment.CurrentDirectory, Name + ".xlsx");
            bool Add = false;

            if (!Directory.Exists(sPath))
            {
                Directory.CreateDirectory(sPath);
            }

            if (!File.Exists(sFilePath))
            {
                File.Create(sFilePath);
            }

            //License li = new License();
            //li.SetLicense("lib/License.lic");
            Workbook workBook = new Workbook(sFilePath);   
            Worksheet sheet = workBook.Worksheets[0]; //工作表  
            
            Cells cells = sheet.Cells;//单元格 
            int rowCount = sheet.Cells.MaxDataRow; //竖着数最后一行的标号

            //检查是否存在同样的数据
            if (sheet != null)
            {
                string str = string.Empty;

                for (int i = 0; i < rowCount; i++)
                {
                    str = cells[i, 0].StringValue.Trim() + "," +
                        cells[i, 1].StringValue.Trim() + "," +
                        cells[i, 2].StringValue.Trim() + "," +
                        cells[i, 3].StringValue.Trim() + "," +
                        cells[i, 4].StringValue.Trim() + "," +
                        cells[i, 5].StringValue.Trim() + "," +
                    cells[i, 6].StringValue.Trim();
                    string[] strArray = str.Split(','); //字符串转数组

                    if (CompareArray(strArray, Data))
                    {
                        cells[i, 7].PutValue(Convert.ToInt32(cells[i, 7].StringValue.Trim()) + 1); //添加数据
                        break;
                    }
                    else
                    {
                        Add = true;
                    }
                }
            }
            else
            {
                Add = true;
            }

            if (Add)
            {
                for (int i = 0; i < Data.Length; i++)
                {
                    cells[rowCount, i].PutValue(Data[i]);
                }
                cells[rowCount, 7].PutValue(1);
            }

            workBook.Save(sFilePath);
        }

        static string GetExcelMapDataType(string dataType)
        {
            string result = dataType;
            switch (dataType.ToLower())
            {
                case "int":
                case "int32":
                    result = "INTEGER";
                    break;
                case "datetime":
                    result = "DATE";
                    break;
                case "boolean":
                    result = "bit";
                    break;
                default:
                    break;
            }

            return result;
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
}
