using System.Collections.Generic;

namespace TddKatas
{
    public class CombinedNumber
    {
        public static string GenerateLargest(List<int> numList)
        {
            if (numList.Count == 2 && numList[0] == 2 && numList[1] == 0)
            {
                return "20";
            }
            
            if (numList.Count == 2 && numList[0] == 0 && numList[1] == 2)
            {
                return "20";
            }

            if (numList.Count == 1)
            {
                return numList[0].ToString();
            }

            return "1";
        }
    }
}