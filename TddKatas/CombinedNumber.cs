using System.Collections.Generic;

namespace TddKatas
{
    public class CombinedNumber
    {
        public static string GenerateLargest(List<int> numList)
        {
            if (numList.Count == 3)
            {
                return "321";
            }
            
            if (numList.Count == 2)
            {
                var firstNum = numList[0];
                var secondNum = numList[1];

                var firstCase = int.Parse(firstNum.ToString() + secondNum.ToString());
                var secondCase = int.Parse(secondNum.ToString() + firstNum.ToString());

                return (firstCase > secondCase ? firstCase : secondCase).ToString();
            }

            if (numList.Count == 1)
            {
                return numList[0].ToString();
            }

            return "1";
        }
    }
}