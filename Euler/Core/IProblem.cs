using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Core
{
    public interface IProblem<T>
    {
        string Name { get; }

        T Solve(params string[] input);
    }
}
