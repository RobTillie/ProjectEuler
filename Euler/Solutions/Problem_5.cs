using Euler.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Solutions
{
    public class Problem_5 : IProblem<int>
    {
        public string Name => "Smallest multiple";

        public int Solve(params string[] input)
        {
            for(int i = 20; i < int.MaxValue; i+= 20)
            {
                bool isValid = true;

                for(int j = 1; j <= 20; j++)
                {
                    if (i % j != 0)
                    {
                        isValid = false;
                        break;
                    }
                }

                // if we reach this point, i is divisble by every j
                if (isValid)
                {
                    return i;
                }
            }

            return 0;
        }
    }
}
