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
            var primes = new[] {2, 3, 5};

            foreach (var prime in primes)
            {
                if (number > prime && number % prime == 0)
                {
                    var temp = GetInner(number / prime);
                    return temp.Concat(new[] {prime}).ToArray();
                }
            }

            return new[] {number};
        }
    }
}