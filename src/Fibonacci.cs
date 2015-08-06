using System;

namespace CSharp.Basic.katas
{
    public class Fibonacci
    {
        private Func<int, int> fib;

        public int Get(int nth)
        {
            fib = n => n > 1 ? fib(n - 1) + fib(n - 2) : n;

            return fib( nth );
        }
    }
}
