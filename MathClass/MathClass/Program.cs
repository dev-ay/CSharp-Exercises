using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Provide an integer to add 10 to: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(A + " + 10 = " + Math.add10(A));
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Provide an integer to double: ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(B + " * 2 = " + Math.time2(B));
            Console.WriteLine();
            Console.WriteLine();


            Console.Write("Provide an integer to square: ");
            int C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(C + " * " + C + " = " + Math.square(C));
            Console.WriteLine();
            Console.WriteLine();





            Console.ReadLine();
        }

        
    }
}
