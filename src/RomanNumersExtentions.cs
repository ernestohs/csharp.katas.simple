namespace Basic.katas
{
    public static class RomanNumersExtentions
    {
        private static readonly uint[] Nums = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        private static readonly string[] Rum = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        public static string ToRomanNumber(this uint number)
        {
            string output = string.Empty;

            for (int i = 0; i < Nums.Length && number != 0; i++)
            {
                while (number >= Nums[i])
                {
                    number -= Nums[i];
                    output += Rum[i];
                }
            }

            return output;
        }

    }
}
