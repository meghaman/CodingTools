using NUnit.Framework;
using CodingTools.Algorithms;

namespace CodingToolsTest.Algorithms
{
    public class Palindrome_Tests
    {
        Palindrome pl;

        [SetUp]
        public void SetUp()
        {
            pl = new Palindrome();
        }

        [Test]
        public void NullTest()
        {
            Assert.AreEqual(true, pl.IsPalindrome(null));
        }

        [Test]
        public void SingleDigitTest()
        {
            Assert.AreEqual(true, pl.IsPalindrome(5));
        }

        [Test]
        public void MultipleDigitEvenFail()
        {
            Assert.AreEqual(false, pl.IsPalindrome(3456));
        }

        [Test]
        public void MultipleDigitEvenPass()
        {
            Assert.AreEqual(true, pl.IsPalindrome(3443));
        }

        [Test]
        public void MultipleDigitOddFail()
        {
            Assert.AreEqual(false, pl.IsPalindrome(345));
        }

        [Test]
        public void MultipleDigitOddPass()
        {
            Assert.AreEqual(true, pl.IsPalindrome(343));
        }
    }
}
