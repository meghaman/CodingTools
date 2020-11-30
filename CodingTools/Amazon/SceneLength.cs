using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingTools.Amazon
{
	public class SceneLength
	{
        public List<int> lengthEachScene(List<char> inputList)
        {
            List<int> scenes = new List<int>();
            try
            {
                // WRITE YOUR CODE HERE
                // Take first letter in list and find index of last occurrence
                char firstLetter = inputList.First();
                int lastOccurrence = inputList.FindLastIndex(x => x == firstLetter);

                // Get all distinct letters between first and last occurrence
                List<char> shotsInScene = inputList.Take(lastOccurrence).Distinct().ToList();

                int max = lastOccurrence;
                // Get last occurrence for all returned letters
                foreach (char shot in shotsInScene)
                {
                    max = Math.Max(max, inputList.FindLastIndex(x => x == shot));
                }

                // Store Max
                scenes.Add(max + 1);

                // Check if remaining list  is empty
                if (inputList.Count > max + 1)
                {
                    scenes = scenes.Concat(lengthEachScene(inputList.Skip(max + 1).ToList())).ToList();
                    // Recursive call with remaining list first letter and remaining string
                    // Attached returned array to Max;
                }
            }
            catch (Exception e)
            {
            }

            return scenes;
        }
    }
}
