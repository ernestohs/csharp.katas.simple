using System;
using System.Collections.Generic;

namespace CSharp.Basic.katas
{
    public class CannonicalComparer<T> : IComparer<T> where T : IComparable
    {
        public int Compare(T x, T y)
        {
            return x.CompareTo(y);
        }
    }
}