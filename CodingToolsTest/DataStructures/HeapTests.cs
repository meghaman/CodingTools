using NUnit.Framework;
using CodingTools.DataStructures;
using System.Collections.Generic;
using System;

namespace CodingToolsTest.DataStructures
{
	public class HeapTests
	{
		private Heap _heap;

		[SetUp]
		public void Setup()
		{
			_heap = new Heap(new List<int> { 12, 7, 10, 15, 3, 2, 10 });
		}

		[Test]
		public void BaseTest()
		{
			_heap.Insert(1);

			Assert.AreEqual(1, _heap.Pop());
			Assert.AreEqual(2, _heap.Pop());
			Assert.AreEqual(3, _heap.Pop());
			Assert.AreEqual(7, _heap.Pop());
			Assert.AreEqual(10, _heap.Pop());
			Assert.AreEqual(10, _heap.Pop());
			Assert.AreEqual(12, _heap.Pop());
			Assert.AreEqual(15, _heap.Pop());

			Assert.Throws<IndexOutOfRangeException>(delegate { _heap.Pop(); });
		}
	}
}