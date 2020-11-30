using System;
using System.Collections.Generic;
using System.Text;
using CodingTools.Amazon;
using NUnit.Framework;

namespace CodingToolsTest.Amazon_Tests
{
	public class TopCompetitors_Tests
	{
		private TopCompetitors _topCompetitors;

		[SetUp]
		private void SetUp()
		{
			_topCompetitors = new TopCompetitors();
		}

		[Test]
		private void BaseUseCase()
		{
            var test = _topCompetitors.topNCompetitors(
                    5,
                    5,
                    new List<string>()
                    {
                        "anacell", "betacellular", "cetracular", "deltacellular", "eurocell"
                    },
                    5,
                    new List<string>() {
                        "I love anacell Best services provided by anacell in the town",
                        "Betacellular has great services",
                        "deltacellular provides much better services than Betacellular",
                        "cetracular is worse than eurocell",
                        "Betacellular is better than deltacellular"
                    });
        }
    }
}
