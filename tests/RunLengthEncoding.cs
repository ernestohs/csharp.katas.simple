using Basic.Katas;
using NUnit.Framework;

namespace Basic.Katas.Tests
{
    [TestFixture]
    class RunLengthEncodingTests
    {
        [TestCase("aaaaaabcddccc", "6a1b1c2d3c")]
        [TestCase("AAAAAAAAAAAAAAA", "15A")]
        [TestCase("AAAAAAbbbXXXXXt", "6A3b5X1t")]
        [TestCase("Xtmprsqzntwlfb", "1X1t1m1p1r1s1q1z1n1t1w1l1f1b")]   
        [TestCase("WWWWWWWWWWWWBWWWWWWWWWWWWBBBWWWWWWWWWWWWWWWWWWWWWWWWBWWWWWWWWWWWWWW", "12W1B12W3B24W1B14W")]   
        public void EncodingTest(string input, string expected)
        {
            var target = new RunLengthEncoding();
            string actual = target.Encode(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("aaaaaabcddccc", "6a1b1c2d3c")]
        [TestCase("AAAAAAAAAAAAAAA", "15A")]
        [TestCase("AAAAAAbbbXXXXXt", "6A3b5X1t")]
        [TestCase("Xtmprsqzntwlfb", "1X1t1m1p1r1s1q1z1n1t1w1l1f1b")]   
        [TestCase("WWWWWWWWWWWWBWWWWWWWWWWWWBBBWWWWWWWWWWWWWWWWWWWWWWWWBWWWWWWWWWWWWWW", "12W1B12W3B24W1B14W")]   
        public void DecodingTest(string expected, string input)
        {
            var target = new RunLengthEncoding();
            string actual = target.Decode(input);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
