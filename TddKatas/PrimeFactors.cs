using System.Collections.Generic;
using System.Linq;

namespace TddKatas
{
    public static class PrimeFactors
    {
        public static int[] Get(int number)
        {
            if (number > 2 && number % 2 == 0)
            {
                var temp = GetInner(number / 2);
                return temp.Concat(new[] {2}).ToArray();
            }

            return GetInner(number);
        }

        private static int[] GetInner(int number)
        {
            var primes = new[] {2, 3, 5};

            foreach (var prime in primes)
            {
                if (number > prime && number % prime == 0)
                {
                    return new[] {prime, number / prime};
                }
            }

            return new[] {number};
        }
    }
}