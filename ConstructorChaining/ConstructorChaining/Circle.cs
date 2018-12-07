using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChaining
{
    class Circle
    {
        public double radius;
        public double diameter;


        public Circle(double length) : this(length, true)
        {
        }

        public Circle(double length, bool rad)
        {
            if (rad)
            {
                radius = length;
                diameter = 2 * radius;
            }
            else
            {
                diameter = length;
                radius = length / 2;
            }
        }



    }
}
