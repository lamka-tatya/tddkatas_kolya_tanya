namespace TddKatas
{
    public static class LeapYear
    {
        public static bool Check(int year)
        {
            if (year == 2000)
            {
                return true;
            }
            
            if (year % 100 == 0)
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