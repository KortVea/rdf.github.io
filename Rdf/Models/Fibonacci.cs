using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rdf.Models
{
    public class Fibonacci
    {
        long[] memo;
        int input;
        int nth => Math.Abs(input);
        bool isNegative => input < 0 && input % 2 == 0;

        public Fibonacci(int n)
        {
            input = n;
            memo = new long[nth + 1];
        }

        public long GetNth()
        {
            var temp = GetNth(nth);
            return isNegative ? -temp : temp;
        }

        long GetNth(int n)
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