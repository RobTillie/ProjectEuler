using Euler.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Solutions
{
    public class Problem_3 : IProblem<int>
    {
        public string Name => "Largest prime factor";

        public int Solve(params string[] input)
        {
            var n = 600851475143L;
            var factor = 2;
            var lastFactor = 1;

            while (n > 1)
            {
                if (n % factor == 0)
                {
                    lastFactor = factor;
                    n = n / factor;

                    while (n % factor == 0)
                        n = n / factor;

                    factor++;
                }
            }

            return lastFactor;
        }
    }
}
