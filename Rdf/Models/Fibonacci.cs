using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rdf.Models
{
    public class Fibonacci
    {
        long[] memo;
        int nth;

        public Fibonacci(int n)
        {
            memo = new long[n + 1];
            nth = n;
        }

        public long GetNth(int n)
        {
            if (memo[n] != 0) return memo[n];

            if (n == 0) return 0;
            if (n == 1) return 1;
            memo[n] = GetNth(n - 1) + GetNth(n - 2);
            return memo[n];
        }
    }
}