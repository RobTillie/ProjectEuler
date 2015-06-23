using Euler.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Solutions
{
    public class Problem_6 : IProblem<long>
    {
        public string Name => "Sum square difference";

        public long Solve(params string[] input)
        {
            var ceiling = 100;
            var sumOfSquare = MathFunctions.SumOfSquare(ceiling);
            var squareOfSum = MathFunctions.SquareOfSum(ceiling);

            return squareOfSum - sumOfSquare;
        }
    }
}
