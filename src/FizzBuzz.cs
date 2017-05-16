namespace Basic.katas
{
    using System.Globalization;

    public class FizzBuzz
    {
        /// <summary>
        /// FizzBuzz Compute Method
        /// * If the number is divisible by three then the result will be "Fizz"
        /// * If the number is divisible by five then the result will be "Buzz"
        /// * If the number is divisible by three and five then the result will be "FizzBuzz"
        /// </summary>
        /// <param name="number">Number to compute</param>
        /// <returns>Computed result</returns>
        public string Compute(int number)
        {
            string value;

            if (number % 15 == 0) value = "FizzBuzz";
            else if (number % 3 == 0) value = "Fizz";
            else if (number % 5 == 0) value = "Buzz";
            else value = number.ToString(CultureInfo.InvariantCulture);

            return value;
        }
    }
}
