using System.Collections.Generic;
using System.Linq;

namespace CodingTools.Amazon
{
	public class TopCompetitors
	{
        public List<string> topNCompetitors(int numCompetitors,
                                            int topNCompetitors,
                                            List<string> competitors,
                                            int numReviews, List<string> reviews)
        {
            // WRITE YOUR CODE HERE
            Dictionary<string, int> reviewerCount = new Dictionary<string, int>();

            competitors.ForEach(x => reviewerCount.Add(x, 0));

            // Iterate over reviews
            foreach (string review in reviews)
            {
                string lowerCaseReview = review.ToLower();
                // Check if review contains each competitors
                foreach (string competitor in competitors)
                {
                    if (lowerCaseReview.Contains(competitor))
                    {
                        // Keep count of reviews
                        reviewerCount[competitor]++;
                    }
                }
            }
            // Return list of competitors based on count

            if (topNCompetitors > numCompetitors)
            {
                var emptiesRemoved = reviewerCount.Where(x => x.Value != 0).ToList();
            }

            var ordered = reviewerCount
                .Where(x => x.Value > 0 || topNCompetitors < numCompetitors)
                .OrderByDescending(x => x.Value)
                .ThenByDescending(x => x.Key)
                .ToDictionary(x => x.Key);

            return (ordered.Keys.Take(topNCompetitors).ToList());
        }
    }
}
