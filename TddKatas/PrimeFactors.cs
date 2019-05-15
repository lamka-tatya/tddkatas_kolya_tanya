namespace TddKatas
{
    public static class PrimeFactors
    {
        public static int[] Get(int number)
        {
            if (number == 4)
            {
                return new[] {2, 2};
            }
            
            return new[] {number};
        }
    }
}
