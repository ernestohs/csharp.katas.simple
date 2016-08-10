using System;
using NUnit.Framework;
using CSharp.Basic.katas;

namespace CSharp.Basic.Katas.Tests
{
    [TestFixture]
    public class SortingAlgorithmsFixture
    {
        [TestCase(new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'y', 'z' }, new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'y', 'z' })]
        [TestCase(new[] { 'z', 'y', 'x', 'v', 'u', 't', 's', 'r', 'q', 'p', 'o', 'n', 'm', 'l', 'k', 'j', 'i', 'h', 'g', 'f', 'e', 'd', 'c', 'b', 'a' }, new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'y', 'z' })]
        public void BubleSortCharacterTest(char[] original, char[] expected)
        {
            var target = new BubleSort(); // TODO: Use and Interface in order to re-use these tests to execute different algorithms.

            var actual = target.Sort(original);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        [TestCase(new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        [TestCase(new[] { 6, 7, 8, 9, 10, 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        public void BubleSortIntegerTest(int[] original, int[] expected)
        {
            var target = new BubleSort();

            var actual = target.Sort(original);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void BubleSortTestNullInput()
        {
            var target = new BubleSort();

            Assert.Throws<ArgumentNullException>( () => target.Sort<int>(null));
        }

    }
}
