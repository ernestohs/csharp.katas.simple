namespace Basic.katas
{
    public static class PerfectNumberExtention
    {
        public static bool IsPerfect(this int number)
        {
            if (number == 0) return false;

            int sum = 0;

            for (var i = 1; i < number; i++)
            {
                if (number%i != 0) continue;

                sum += i;
            }

            return sum == number;
        }
    }
}
