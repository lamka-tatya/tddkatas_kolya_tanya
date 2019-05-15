namespace TddKatas
{
    public static class PrimeFactors
    {
        public static int[] Get(int number)
        {
            if (number == 3)
            {
                return new[] {3};
            }
            
            if (number == 5)
            {
                return new[] {5};
            }
            
            return new[] {2};
        }
    }
}
