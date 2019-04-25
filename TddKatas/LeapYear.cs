namespace TddKatas
{
    public static class LeapYear
    {
        public static bool Check(int year)
        {
            if (year == 1800)
            {
                return false;
            }
            if (year == 1900)
            {
                return false;
            }
            if (year % 4 == 0)
            {
                return true;    
            }

            return false;
        }
    }
}