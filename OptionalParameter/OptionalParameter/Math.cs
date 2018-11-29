using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    class Math
    {
        public int PiggyBank(int rate, int savings = 0)
        {
            return (40 * rate * 52 + savings);
        }

    }
}
