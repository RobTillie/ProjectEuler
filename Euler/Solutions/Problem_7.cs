using Euler.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Solutions
{
    public class Problem_7 : IProblem<long>
    {
        public string Name => "10001st prime";

        public long Solve(params string[] input)
        {
            return MathFunctions.FindPrimeNumber(10001);
        }
    }
}
