namespace TddKatas
{
    public static class PrimeFactors
    {
        public static int[] Get(int number)
        {
            if (number == 6)
            {
                return new[] {3, 2};
            }
            
            if (number == 4)
            {
                return new[] {2, 2};
            }
            
            return new[] {number};
        }
    }
}
