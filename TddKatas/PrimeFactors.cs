using System.Collections.Generic;

namespace TddKatas
{
    public static class PrimeFactors
    {
        public static int[] Get(int number)
        {
            var primes = new[] {3, 2};

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