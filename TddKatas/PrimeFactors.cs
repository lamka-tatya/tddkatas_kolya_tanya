using System.Collections.Generic;
using System.Linq;

namespace TddKatas
{
    public static class PrimeFactors
    {
        public static int[] Get(int number)
        {

            return GetInner(number);
        }

        private static int[] GetInner(int number)
        {
            for (var divisor = 2; divisor < number; divisor++)
            {
                if (number > divisor && number % divisor == 0)
                {
                    var temp = GetInner(number / divisor);
                    return temp.Concat(new[] {divisor}).ToArray();
                } 
            }

            return new[] {number};
        }
    }
}