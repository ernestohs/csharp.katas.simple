using System.Linq;
using System.Text;

namespace Basic.katas
{
    public class RunLengthEncoding
    {
        /// <summary>
        /// Encode for Run-Length Encoding
        /// Given a string containing characters (A-Z), compress repeated 'runs' 
        /// of the same character by storing the length of that run, and provide a function 
        /// to reverse the compression. The output can be anything, as long as you can recreate 
        /// the input with it.
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns>Encoded string</returns>
        public string Encode(string input)
        {
            int count = 0;

            var outputBuilder = new StringBuilder();
            char current = input.First();

            foreach (var character in input)
            {
                if (current == character)
                {
                    count++;
                } 
                else 
                {
                    outputBuilder.AppendFormat("{0}{1}", count, current);
                    count = 1;
                    current = character;
                }
            }

            outputBuilder.AppendFormat("{0}{1}", count, current);
            return outputBuilder.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string Decode(string input)
        {
            string a = string.Empty;
            var output = new StringBuilder();

            foreach (var current in input)
            {
                if (char.IsDigit(current))
                    a += current;
                else
                {
                    int count = int.Parse(a);
                    a = "";
                    for (var i = 0; i < count; i++)
                        output.Append(current);
                }
            }

            return output.ToString();
        }
    }
}
