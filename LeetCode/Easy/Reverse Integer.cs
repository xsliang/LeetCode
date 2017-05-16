//Reverse digits of an integer.

//Example1: x = 123, return 321
//Example2: x = -123, return -321

//click to show spoilers.

//Note:
//The input is assumed to be a 32-bit signed integer.Your function should return 0 when the reversed integer overflows.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Reverse_Integer
    {
        public int Reverse(int x)
        {
            string strX = x.ToString();
            bool negative = false;
            if (strX[0].ToString() == "-")
            {
                negative = true;
                strX = strX.Replace("-", "");
            }
            string strResult = "";
            if (strX.Length > 1)
            {
                for (int i = strX.Length - 1; i >= 0; i--)
                {
                    strResult = strResult + strX[i].ToString();
                }
            }
            else
            {
                strResult = strX;
            }
            if (negative == true)
            {
                strResult = "-" + strResult;
            }
            int result = 0;
            int.TryParse(strResult, out result);
            return result;
        }
    }
}
