using System.Linq;

namespace CodingTools.BlueDot
{
	public class BlueDotB
	{
		/*
		 * Take first bucket
			Check if remaining water can take this bucket
				if reduce to 0; then add to total count and return;
				if no more buckets and water remaining do not add 1;

				Reduce quantity of remaining water
				Call on remaning buckets and water


			Call on remaining buckets original water

			Sum total

		 */
		public int solution(int[] A)
		{
			var removeTooLargeBuckets = A.Where(x => x <= 150).OrderBy(x => x).ToArray();

			DetermineNumberOfPaths(150, removeTooLargeBuckets);

			return numberOfPaths;
		}

		int numberOfPaths = 0;

		public void DetermineNumberOfPaths(int remainingWater, int[] remainingBuckets)
		{
			if (remainingBuckets.Length == 0)
				return;

			int currentBucket = remainingBuckets[0];

			if(remainingWater == currentBucket)
			{
				numberOfPaths++;
				return;
			}

			if(remainingWater > currentBucket)
			{
				if (remainingBuckets.Length == 0)
					return;

				DetermineNumberOfPaths(remainingWater - currentBucket, remainingBuckets.Skip(1).ToArray());
			}

			DetermineNumberOfPaths(remainingWater, remainingBuckets.Skip(1).ToArray());
		}
	}
}
