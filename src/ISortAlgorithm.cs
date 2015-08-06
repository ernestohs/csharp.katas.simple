using System;
using System.Collections.Generic;

namespace CSharp.Basic.katas
{
    public interface ISortAlgorithm
    {
        IEnumerable<T> Sort<T>(IEnumerable<T> input, IComparer<T> comparer = null) where T : IComparable;
    }
}