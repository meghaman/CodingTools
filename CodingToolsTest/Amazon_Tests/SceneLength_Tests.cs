using NUnit.Framework;
using CodingTools.Amazon;
using System.Collections.Generic;

namespace CodingToolsTest.Amazon_Tests
{
	public class SceneLength_Tests
	{
		private SceneLength _sceneLength;

		[SetUp]
		public void SetUp()
		{
			_sceneLength = new SceneLength();
		}

		[Test]
		public void BaseTest()
		{
			var baseTest = _sceneLength.lengthEachScene(new List<char>()
			{
				'z', 'z', 'c', 'b', 'z', 'c', 'h', 'f', 'i', 'h', 'i'
			});

			Assert.IsTrue(baseTest[0] == 5);
			Assert.IsTrue(baseTest[1] == 5);
		}
	}
}
