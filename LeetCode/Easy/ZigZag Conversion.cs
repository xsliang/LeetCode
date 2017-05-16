// The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)

//P A H N
//A P L S I I G
//Y I R

//And then read line by line: "PAHNAPLSIIGYIR"

//Write the code that will take a string and make this conversion given a number of rows:

//string convert(string text, int nRows);

//convert("PAYPALISHIRING", 3) should return "PAHNAPLSIIGYIR". 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ZigZag_Conversion
    {
        public string Convert(String s, int nRows)
        {
            string result = string.Empty;

            char[] inputString = s.ToArray();

            List<string[]> lstString = new List<string[]>();
            string[] aryColumn = new string[nRows];
            bool beginZig = false;
            int currentRowIndeTypeA = 1;
            int currentRowIndeTypeB = nRows;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (beginZig == false)
                {
                    aryColumn[currentRowIndeTypeA - 1] = s.Substring(i, 1);
                    if (currentRowIndeTypeA == nRows)
                    {
                        lstString.Add(aryColumn);
                        aryColumn = new string[nRows];
                        currentRowIndeTypeA = 1;
                        if (nRows < 3)
                        {
                            beginZig = false;
                        }
                        else
                        {
                            beginZig = true;
                        }
                        continue;
                    }
                    else
                    {
                        currentRowIndeTypeA = currentRowIndeTypeA + 1;
                    }
                    if (i == inputString.Length - 1)
                    {
                        lstString.Add(aryColumn);
                        continue;
                    }
                }
                else
                {
                    currentRowIndeTypeA = 1;
                    aryColumn = new string[nRows];
                    aryColumn[currentRowIndeTypeB - 2] = s.Substring(i, 1);
                    currentRowIndeTypeB = currentRowIndeTypeB - 1;
                    lstString.Add(aryColumn);
                    if (currentRowIndeTypeB - 1 == 1)
                    {
                        currentRowIndeTypeB = nRows;
                        beginZig = false;
                        aryColumn = new string[nRows];
                    }
                }
            }

            for (int i = 0; i < nRows; i++)
            {
                foreach (var item in lstString)
                {
                    if (!string.IsNullOrEmpty(item[i]))
                    {
                        result = result + item[i];
                    }
                }
            }
            lstString.Clear();

            return result;
        }
    }
}
