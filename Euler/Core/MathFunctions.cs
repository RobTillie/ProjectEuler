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

        public static long SumOfSquare(long n)
        {
            long total = 0;

            for (int i = 1; i <= n; i++)
                total += i * i;

            return total;
        }

        public static long SquareOfSum(long n)
        {
            long total = 0;

            for (int i = 1; i <= n; i++)
                total += i;

            return total * total;
        }

        /// <summary>
        /// Checks whether a number is a prima number
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsPrime(long n)
        {
            if (n <= 1) return false;
            
            // we only have to test until Sqrt(n)
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }

            return true;
        }

        /// <summary>
        /// Finds the n-th prime number
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long FindPrimeNumber(int n)
        {
            long primeNumbersFound = 0;
            long currentNumber = 0;

            while (primeNumbersFound < n)
            {
                currentNumber++;

                if (IsPrime(currentNumber))
                {
                    primeNumbersFound++;
                }
            }

            return currentNumber;
        }
    }
}
