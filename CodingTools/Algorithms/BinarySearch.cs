using System.Collections.Generic;
using System.Linq;

public class BinarySearch
{
    List<int> values;

    public BinarySearch(List<int> _values)
    {
        values = _values;
    }

    public int Search(int x, List<int> _values = null)
    {
        if (_values == null)
            _values = values;

        if (values == null || values.Count == 0 || (_values.Count == 1 && _values[0] != x))
            return -1;

        int midpoint = _values.Count / 2;

        if (_values[midpoint] == x)
            return midpoint;

        if (_values[midpoint] < x)
        {
            int recursedValue = Search(x, _values.Skip(midpoint).ToList());
            return recursedValue == -1 ? recursedValue : recursedValue + midpoint;
        }

        return Search(x, _values.Take(midpoint).ToList());
    }
}