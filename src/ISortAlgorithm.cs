using System;
using System.Collections.Generic;

namespace Basic.Katas
{
    public interface ISortAlgorithm
    {
        IEnumerable<T> Sort<T>(IEnumerable<T> input, IComparer<T> comparer = null) where T : IComparable;
    }
}