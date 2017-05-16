using System;
using System.Collections.Generic;

namespace Basic.Katas
{
    public class CannonicalComparer<T> : IComparer<T> where T : IComparable
    {
        public int Compare(T x, T y)
        {
            return x.CompareTo(y);
        }
    }
}