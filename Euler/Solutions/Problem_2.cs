using Euler.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Solutions
{
    public class Problem_2 : IProblem<int>
    {
        public string Name => "Even Fibonacci numbers";

        public int Solve(params string[] input)
        {
            var sum = 0;
            var limit = 4000000;

            int a = 1;
            int b = 1;

            while (b < limit)
            {
                if (b % 2 == 0) sum += b;
                var next = a + b;
                a = b;
                b = next;
            }

            return sum;
        }
    }
}
