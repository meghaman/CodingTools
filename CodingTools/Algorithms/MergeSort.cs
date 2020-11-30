using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTools
{
    public class MergeSort
    {
        // Given Array of integers
        public List<int> Sort(List<int> values)
        {
            // If Count 1, return element
            if (values.Count == 1)
                return values;

            List<int> sortedValues = new List<int>();

            // Chop list in half (A & B)
            List<int> a;
            List<int> b;

            // Find the Count of both arrays
            a = values.Take(values.Count / 2).ToList();
            b = values.Skip(values.Count / 2).ToList();

            // Sort A (recursive call)
            a = Sort(a);
            // Sort B (recursive call)
            b = Sort(b);

            // Merge A & B
            // Iterate through both lists
            do
            {
                // Compare lowest elements from both
                if(a.First() <= b.First())
                {
                    // Put removed element in new array
                    sortedValues.Add(a[0]);

                    // Remove lower element from A or B
                    a = a.Skip(1).ToList();
                }
                else
                {
                    sortedValues.Add(b[0]);
                    b = b.Skip(1).ToList();
                }
            }
            // Continue while either list is not empty
            while (a.Count > 0 && b.Count > 0);

            // Add remaining elements to end of new list
            if (a.Count > 0)
                sortedValues.AddRange(a);
            if (b.Count > 0)
                sortedValues.AddRange(b);

            // Return new list
            return sortedValues;
        }
    }
}

