//Implement atoi to convert a string to an integer.

//Hint: Carefully consider all possible input cases. If you want a challenge, please do not see below and ask yourself what are the possible input cases.

//Notes: It is intended for this problem to be specified vaguely (ie, no given input specs). You are responsible to gather all the input requirements up front.

//Update (2015-02-10):
//The signature of the C++ function had been updated.If you still see your function signature accepts a const char* argument, please click the reload button to reset your code definition.

//spoilers alert... click to show requirements for atoi.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Middle
{
    class String_to_Integer__atoi_
    {
        public int MyAtoi(string str)
        {
            string result = "0";
            int tempResult = 0;
            bool begin = false;
            for (int i = 0; i < str.Length; i++)
            {
                char temp = str[i];
                switch (temp.ToString())
                {
                    case " ":
                        if (begin == true)
                        {
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    case "+":
                        if (begin == true)
                        {
                            return 0;
                        }
                        else
                        {
                            begin = true;
                            result = "0";
                        }
                        continue;
                    case "-":
                        if (begin == true)
                        {
                            return 0;
                        }
                        else
                        {
                            begin = true;
                            result = "-0";
                        }
                        continue;
                    default:
                        break;
                }
                begin = true;
                tempResult = 0;
                if (int.TryParse(temp.ToString(), out tempResult) == true)
                {
                    result = result + tempResult.ToString();
                }
                else
                {
                    if (begin == true)
                    {
                        break;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            if (!string.IsNullOrEmpty(result))
            {
                long lTemp = 0;
                if (result[0].ToString() != "-" && int.TryParse(result.ToString(), out tempResult) == false)
                {
                    tempResult = int.MaxValue;
                }
                else if (result[0].ToString() == "-" && int.TryParse(result.ToString(), out tempResult) == false)
                {
                    tempResult = int.MinValue;
                }
                else
                {
                    int.TryParse(result, out tempResult);
                }
            }

            return tempResult;
        }
    }
}
