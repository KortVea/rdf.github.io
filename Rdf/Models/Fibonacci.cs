using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rdf.Models
{
    public class Fibonacci
    {
        ulong[] memo;

        public Fibonacci(int n)
        {
            memo = new ulong[n + 1];
        }

        public ulong GetNth(int n)
        {
            if (memo[n] != 0) return memo[n];

            if (n == 0) return 0;
            if (n == 1) return 1;
            memo[n] = GetNth(n - 1) + GetNth(n - 2);
            if (memo[n] <= memo[n-1])
            {
                throw new OverflowException();
            }
            return memo[n];
        }
    }
}