using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Basic.katas
{
    public class BubleSort : ISortAlgorithm
    {
        public IEnumerable<T> Sort<T>(IEnumerable<T> input, IComparer<T> comparer = null) where T : IComparable
        {
            var array = input.ToArray();

            bool notSorted = true;

            if (comparer == null)
            {
                comparer = new CannonicalComparer<T>();
            }

            while (notSorted)
            {
                notSorted = false;
                for (var i = 0; i < array.Length - 1; i++)
                {
                    var x = array[i];
                    var y = array[i + 1];
                    
                    if (comparer.Compare(x, y) <= 0) continue;

                    array[i] = y;
                    array[i + 1] = x;
                    notSorted = true;
                }
            }

            return array;
        }
    }
}
