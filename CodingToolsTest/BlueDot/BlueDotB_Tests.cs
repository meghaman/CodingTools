using System;
using System.Collections.Generic;
using System.Text;
using CodingTools.BlueDot;
using NUnit.Framework;

namespace CodingToolsTest.BlueDot
{
	class BlueDotB_Tests
	{
		BlueDotB bdB;

		[SetUp]
		public void SetUp()
		{
			bdB = new BlueDotB();
		}

		[Test]
		public void TestCases()
		{
			bdB.solution(new int[5] { 50, 50, 100, 150, 200 });
		}
	}
}
