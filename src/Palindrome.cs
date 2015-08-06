using System.Text.RegularExpressions;

namespace CSharp.Basic.katas
{
    public static class Palindrome
    {
        const string Pattern = @"[^\w\d]";
        const string Replacement = "";

        public static bool IsPalindrome(this string value)
        {
            var result = true;

            // clean
            var regEx = new Regex(Pattern);
            string sanitized = regEx.Replace(value.ToLowerInvariant(), Replacement);

            int left = 0;
            int right = sanitized.Length - 1;

            // validate
            do
            {
                if (sanitized[left++] == sanitized[right--]) continue;

                result = false;
                break;
            } while (left > right);

            return result; 
        }
    }
}
