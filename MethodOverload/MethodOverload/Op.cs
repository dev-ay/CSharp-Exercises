using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    class Op
    {
        public int Operate(int X)
        {
            return X * 2;
        }


        public int Operate(decimal x)
        {
            return (int)Math.Ceiling(x);
        }

        public int Operate(string x)
        {
            switch (x)
            {
                case "One":
                    return (int)Math.Pow(10,1);
                case "Two":
                    return (int)Math.Pow(10, 2);
                case "Three":
                    return (int)Math.Pow(10, 3);
                case "Four":
                    return (int)Math.Pow(10, 4);
                case "Five":
                    return (int)Math.Pow(10, 5);
                default:
                    return -1;
            }
        }

    }
}
