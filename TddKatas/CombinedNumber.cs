using System.Collections.Generic;

namespace TddKatas
{
    public class CombinedNumber
    {
        public static string GenerateLargest(List<int> numList)
        {
            if (numList.Count == 1)
            {
                return numList[0].ToString();
            }
            
            return "1";
        }
    }
}