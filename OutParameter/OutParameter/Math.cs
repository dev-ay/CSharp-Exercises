using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParameter
{
    class Math
    {

        public int divide(int x)
        {
            return x / 2;
        }


        public void divide(int x, out int result)
        {
            result = x / 2;
        }


        public static int Divide(int x)
        {
            return x / 2;
        }


    }
}
