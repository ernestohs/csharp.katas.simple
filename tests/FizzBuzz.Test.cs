using System.Linq;
using CSharp.Basic.katas;
using NUnit.Framework;

namespace CSharp.Basic.Katas.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void TestFizz()
        {
            var target = new FizzBuzz();
            var expected = "Fizz";
            var actual = target.Compute(3);
            Assert.That(actual, Is.Not.Null);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestBuzz()
        {
            var target = new FizzBuzz();
            var expected = "Buzz";
            var actual = target.Compute(5);
            Assert.That(actual, Is.Not.Null);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestFizzBuzz()
        {
            var target = new FizzBuzz();
            var expected = "FizzBuzz";
            var actual = target.Compute(15);
            Assert.That(actual, Is.Not.Null);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test1To20()
        {
            var target = new FizzBuzz();
            var collection = new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz", "16", "17", "Fizz", "19", "Buzz" };

            foreach (var item in collection.Select((value, index) => new { Index = index + 1, Value = value }))
            {
                Assert.That(target.Compute(item.Index), Is.EqualTo(item.Value));
            }
        }

        [Test]
        public void TestOnlyFizz1To100()
        {
            var target = new FizzBuzz();
            var expected = new[] { 3, 6, 9, 12, 18, 21, 24, 27, 33, 36, 39, 42, 48, 51, 54, 57, 63, 66, 69, 72, 78, 81, 84, 87, 93, 96, 99 };

            foreach (var item in expected)
            {
                Assert.That(target.Compute(item), Is.EqualTo("Fizz"));
            }
        }

        [Test]
        public void TestOnlyBuzz1To100()
        {
            var target = new FizzBuzz();
            var expected = new[] { 5, 10, 20, 25, 35, 40, 50, 55, 65, 70, 80, 85, 100 };

            foreach (var item in expected)
            {
                Assert.That(target.Compute(item), Is.EqualTo("Buzz"));
            }
        }

        [Test]
        public void TestOnlyFizzBuzz1To100()
        {
            var target = new FizzBuzz();
            string expected = "FizzBuzz";
            var collection = new[] { 15, 30, 45, 60, 75, 90 };

            foreach (var item in collection)
            {
                string actual = target.Compute(item);
                Assert.That(actual, Is.EqualTo(expected));
            }
        }

        [Test]
        public void TestZero()
        {
            var target = new FizzBuzz();
            var expected = "FizzBuzz";
            var actual = target.Compute(0);

            Assert.That(actual, Is.EqualTo(expected));
        }
        
        [Test]
        public void TestNegativeValues1To20()
        {
            var target = new FizzBuzz();
            var collection = new[] { "-1", "-2", "Fizz", "-4", "Buzz", "Fizz", "-7", "-8", "Fizz", "Buzz", "-11", "Fizz", "-13", "-14", "FizzBuzz", "-16", "-17", "Fizz", "-19", "Buzz" };

            foreach (var item in collection.Select((value, index) => new { Index = -(index + 1), Value = value }))
            {
                Assert.That(target.Compute(item.Index), Is.EqualTo(item.Value));
            }
        }

    }
}
