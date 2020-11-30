using System.Collections.Generic;
using NUnit.Framework;
using CodingTools.Algorithms;

namespace CodingToolsTest.Algorithms
{
    public class GraphSearch_Tests
	{
        GraphNode a;
        GraphNode b;
        GraphNode c;
        GraphNode d;

        [SetUp]
        public void Setup()
        {
            a = new GraphNode();
            b = new GraphNode();
            c = new GraphNode();
            d = new GraphNode();

            a.total = 6;
            b.total = 3;
            c.total = 5;
            d.total = 2;
        }

        //      a
        //  b       c
        //              d

        [Test]
        public void BFS_BaseCaseTest()
        {
            Assert.AreEqual(new List<int>() { 6 }, new BFSearch().Search(a));
        }

        [Test]
        public void BFS_FullTree()
        {
            a.children.Add(b);
            a.children.Add(c);

            c.children.Add(d);

            Assert.AreEqual(new List<int>() { 6, 3, 5, 2 }, new BFSearch().Search(a));
        }

        [Test]
        public void DFS_BaseCaseTest()
        {
            Assert.AreEqual(new List<int>() { 6 }, new DFSearch().Search(a));
        }

        [Test]
        public void DFS_FullTree()
		{
            a.children.Add(b);
            a.children.Add(c);

            c.children.Add(d);

            Assert.AreEqual(new List<int>() { 6, 5, 2, 3 }, new DFSearch().Search(a));
        }
    }
}
