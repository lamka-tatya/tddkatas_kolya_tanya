using System;
using System.Collections.Generic;
using System.Linq;

namespace TddKatas
{
    public class CombinedNumber
    {
        public static string GenerateLargest(List<int> numList)
        {
            if (numList.Count == 3)
            {
                var firstNum = numList[0];
                var secondNum = numList[1];
                var thirdNum = numList[2];

                var cases = new List<int>()
                {
                    int.Parse(firstNum.ToString() + secondNum.ToString() + thirdNum.ToString()),
                    int.Parse(secondNum.ToString() + firstNum.ToString() + thirdNum.ToString()),
                    int.Parse(thirdNum.ToString() + secondNum.ToString() + firstNum.ToString()),
                    int.Parse(thirdNum.ToString() + firstNum.ToString() + secondNum.ToString()),
                    int.Parse(secondNum.ToString() + thirdNum.ToString() + firstNum.ToString()),
                    int.Parse(firstNum.ToString() + thirdNum.ToString() + secondNum.ToString())
                };

                return cases.Max().ToString();
            }

            if (numList.Count == 2)
            {
                var firstNum = numList[0];
                var secondNum = numList[1];

                var firstCase = int.Parse(firstNum.ToString() + secondNum.ToString());
                var secondCase = int.Parse(secondNum.ToString() + firstNum.ToString());

                return Math.Max(firstCase, secondCase).ToString();
            }

            if (numList.Count == 1)
            {
                return numList[0].ToString();
            }

            return "1";
        }
    }
}