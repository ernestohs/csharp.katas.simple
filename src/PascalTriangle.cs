using System;

namespace Basic.katas
{
    public class PascalTriangle
    {
        private const int MaximumValueToCompute = 5000000;

        public static int[] getPascalRow(int n)
        {
            if (n < 0 || n > MaximumValueToCompute)
            {
                throw new ArgumentOutOfRangeException("n", "Should be between 0 and 5000000 inclusive.");
            }

            var row = new int[n + 1];
            row[0] = 1;

            for (int i = 1; i < n / 2 + 1; i++)
            {
                row[i] = row[i - 1] * (n - i + 1) / i;
            }
            for (int i = n / 2 + 1; i <= n; i++)
            {
                row[i] = row[n - i];
            }

            return row;
        }
    }
}
