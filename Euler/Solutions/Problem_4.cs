using Euler.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Solutions
{
    public class Problem_4 : IProblem<int>
    {
        public string Name => "Largest palindrome";

        public int Solve(params string[] input)
        {
            var largestPalindrome = 0;

            for(int a = 100; a <= 999; a++)
            {
                for(int b = 100; b <= 999; b++)
                {
                    var sum = a * b;
                    if (MathFunctions.IsPalindrome(sum) && sum > largestPalindrome)
                        largestPalindrome = sum;
                }
            }

            return largestPalindrome;
        }
    }
}
