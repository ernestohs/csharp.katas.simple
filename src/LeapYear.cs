namespace Basic.katas
{
    public static class LeapYear
    {
        public static bool IsLeapYear(this int year)
        {
            return year % 100 == 0 ? year % 400 ==0 : year % 4 == 0;
        }
    }
}
