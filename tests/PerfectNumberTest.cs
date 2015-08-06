using CSharp.Basic.katas;
using NUnit.Framework;

namespace CSharp.Basic.Katas.Tests
{
    [TestFixture]
    public class PerfectNumberTest
    {
        [TestCase(0, false)]
        [TestCase(1, false)]
        [TestCase(2, false)]
        [TestCase(3, false)]
        [TestCase(4, false)]
        [TestCase(5, false)]
        [TestCase(7, false)]
        [TestCase(8, false)]
        [TestCase(9, false)]
        [TestCase(10, false)]
        [TestCase(11, false)]
        [TestCase(6, true)]
        [TestCase(28, true)]
        [TestCase(496, true)]
        [TestCase(8128, true)]
        [TestCase(33550336, true)]
        public void PerfectNumberTests(int number , bool expected)
        {
            var actual = number.IsPerfect();
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
