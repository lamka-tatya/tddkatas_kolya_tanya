namespace TddKatas
{
    public static class LeapYear
    {
        public static bool Check(int year)
        {
            if (year == 1900 || year % 4 == 0)
            {
                return true;    
            }

            return false;
        }
    }
}