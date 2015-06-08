using Euler.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Solutions
{
    public class Problem_1 : IProblem<int>
    {
        public string Name => "Problem 1: Multiples of 3 and 5";

        public int Solve(params string[] input)
        {
            var total = 0;
            var upperBound = 1000;
            
            for(int i = 0; i < upperBound; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    total += i;
            }

            return total;
        }
    }
}
