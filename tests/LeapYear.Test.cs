using CSharp.Basic.katas;
using NUnit.Framework;

namespace CSharp.Basic.Katas.Tests
{
    [TestFixture]
    public class LeapYear
    {
        [TestCase(1600, true)]
        [TestCase(1660, true)]
        [TestCase(1724, true)]
        [TestCase(1788, true)]
        [TestCase(1848, true)]
        [TestCase(1912, true)]
        [TestCase(1972, true)]
        [TestCase(1601, false)]
        [TestCase(1973, false)]
        public void LeapYearTest(int year, bool expected)
        {
            bool actual = year.IsLeapYear();
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
