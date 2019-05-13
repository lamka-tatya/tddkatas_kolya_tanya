using System.Collections.Generic;

namespace TddKatas
{
    public class CombinedNumber
    {
        public static string GenerateLargest(List<int> numList)
        {
            if (numList.Count == 1 && numList[0] == 10)
            {
                return "10";
            }
            
            return "1";
        }
    }
}