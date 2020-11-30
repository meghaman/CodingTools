using System.Collections.Generic;
using NUnit.Framework;

namespace CodingToolsTest.Algorithms
{
    public class BinarySearchTests
    {
        int x = 9;
        List<int> sortedList;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EmptyTest()
        {
            sortedList = new List<int>() { };

            Assert.AreEqual(-1, new BinarySearch(sortedList).Search(x));
        }

        [Test]
        public void BaseCaseTest()
        {
            sortedList = new List<int>() { 9 };

            Assert.AreEqual(0, new BinarySearch(sortedList).Search(x));
        }

        [Test]
        public void SmallNTest()
        {
            sortedList = new List<int>() { 1, 5, 7, 9, 10 };

            Assert.AreEqual(3, new BinarySearch(sortedList).Search(x));
        }

        [Test]
        public void NotInList()
        {
            sortedList = new List<int>() { 1, 5, 6, 7, 10 };

            Assert.AreEqual(-1, new BinarySearch(sortedList).Search(x));
        }
    }
}
