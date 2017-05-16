//Determine whether an integer is a palindrome.Do this without extra space.

//click to show spoilers.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    class Palindrome_Number
    {
        public bool IsPalindrome(int x)
        {
            string strX = Convert.ToString(x);
            if (strX[0] == '-')
            {
                return false;
            }
            char[] aryX = strX.ToArray();
            if (aryX.Length == 1)
            {
                return true;
            }
            else if (aryX.Length == 2)
            {
                if (aryX[0] != aryX[1])
                {
                    return false;
                }
            }
            else
            {
                for (int i = 0; i < aryX.Length / 2; i++)
                {
                    if (aryX[i] != aryX[aryX.Length - i - 1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
