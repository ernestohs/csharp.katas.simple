using CSharp.Basic.katas;
using NUnit.Framework;

namespace CSharp.Basic.Katas.Tests
{
    [TestFixture]
    public class PalindromeTest
    {
        [TestCase("ada", true)]
        [TestCase("aDa", true)]
        [TestCase("aDA", true)]
        [TestCase("ADA", true)]
        [TestCase("Stanley Yelnats", true)]
        [TestCase("Do geese see God?", true)]
        [TestCase("Was it Eliot's toilet I saw?", true)]
        [TestCase("Murder for a jar of red rum.", true)]
        [TestCase("Some men interpret nine memos.", true)]
        [TestCase("Never odd or even", true)]
        [TestCase("\"Madam, I'm Adam\"", true)]
        [TestCase("\"Madam in Eden, I'm Adam\"", true)]
        [TestCase("ر ب ك ف ك ب ر", true)]
        [TestCase("Don't nod", true)]
        [TestCase("Dogma: I am God", true)]
        [TestCase("Never odd or even", true)]
        [TestCase("Too bad – I hid a boot", true)]
        [TestCase("Rats live on no evil star", true)]
        [TestCase("No trace; not one carton", true)]
        [TestCase("Was it Eliot's toilet I saw?", true)]
        [TestCase("Murder for a jar of red rum", true)]
        [TestCase("May a moody baby doom a yam?", true)]
        [TestCase("Go hang a salami; I'm a lasagna hog!", true)]
        [TestCase("Satan, oscillate my metallic sonatas!", true)]
        [TestCase("A Toyota! Race fast... safe car: a Toyota", true)]
        [TestCase("Straw? No, too stupid a fad; I put soot on warts", true)]
        [TestCase("Are we not drawn onward, we few, drawn onward to new era?", true)]
        [TestCase("Doc Note: I dissent. A fast never prevents a fatness. I diet on cod", true)]
        [TestCase("No, it never propagates if I set a gap or prevention", true)]
        [TestCase("Anne, I vote more cars race Rome to Vienna", true)]
        [TestCase("Sums are not set as a test on Erasmus", true)]
        [TestCase("Kay, a red nude, peeped under a yak", true)]
        [TestCase("Some men interpret nine memos", true)]
        [TestCase("Campus Motto: Bottoms up, Mac", true)]
        [TestCase("Go deliver a dare, vile dog!", true)]
        [TestCase("Madam, in Eden I'm Adam", true)]
        [TestCase("Oozy rat in a sanitary zoo", true)]
        [TestCase("Ah, Satan sees Natasha", true)]
        [TestCase("Lisa Bonet ate no basil", true)]
        [TestCase("Do geese see God?", true)]
        [TestCase("God saw I was dog", true)]
        [TestCase("Dennis sinned", true)]
        [TestCase("Are we not pure? “No sir!” Panama’s moody Noriega brags. “It is garbage!” Irony dooms a man; a prisoner up to new era.", true)]
        public void PalindromeCannonicalTest(string value, bool expected)
        {
            var actual = value.IsPalindrome();
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
