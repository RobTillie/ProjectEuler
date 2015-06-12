using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Core
{
    public static class MathFunctions
    {
        public static bool IsPalindrome(int number)
        {
            string numberAsString = number.ToString();
            int totalLetters = numberAsString.Length;
            int halfLetters = (int)Math.Floor((double)(numberAsString.Length / 2));

            for (int i = 0; i < halfLetters; i++)
            {
                char firstLetter = numberAsString[i];
                char lastLetter = numberAsString[(totalLetters - 1) - i];

                if (firstLetter != lastLetter)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
