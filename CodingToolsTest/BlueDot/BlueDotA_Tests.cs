using NUnit.Framework;
using CodingTools.BlueDot;

namespace CodingToolsTest.BlueDot
{
	class BlueDotA_Tests
	{
		Solution sol;

		[SetUp]
		public void SetUp()
		{
			sol = new Solution();
		}

		[Test]
		public void TestCases()
		{
			sol.solution(3);
		}
	}
}
