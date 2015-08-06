using CSharp.Basic.katas;
using NUnit.Framework;

namespace CSharp.Basic.Katas.Tests
{
    [TestFixture]
    public class FibonacciTests
    {
        [TestCase(0,0)]
        [TestCase(1,1)]
        [TestCase(2,1)]
        [TestCase(3,2)]
        [TestCase(4,3)]
        [TestCase(5,5)]
        [TestCase(6,8)]
        [TestCase(7,13)]
        [TestCase(8,21)]
        [TestCase(9,34)]
        [TestCase(10,55)]
        [TestCase(11, 89)]
        [TestCase(12, 144)]
        [TestCase(13, 233)]
        [TestCase(14, 377)]
        [TestCase(15, 610)]
        [TestCase(16, 987)]
        [TestCase(17, 1597)]
        [TestCase(18, 2584)]
        [TestCase(19, 4181)]

        public void FibonacciTest(int number, int expected)
        {
            var target = new Fibonacci();
            var actual = target.Get(number);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
