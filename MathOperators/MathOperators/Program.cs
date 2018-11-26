using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperators
{
    class Program
    {
        static void Main()
        {

            Console.Write("Enter a Number: ");
            Double A = Convert.ToDouble(Console.ReadLine());
            Console.Write("{0} X 50 = {1}", A, A * 50);
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Enter a Number: ");
            Double B = Convert.ToDouble(Console.ReadLine());
            Console.Write("{0} + 25 = {1}", B, B + 25);
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Enter a Number: ");
            Double C = Convert.ToDouble(Console.ReadLine());
            Console.Write("{0} / 12.5 = {1}", C, C / 12.5);
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Enter a Number: ");
            Double D = Convert.ToDouble(Console.ReadLine());
            Console.Write("Is {0} greater than 50? ==> ",D);
            Console.Write(D > 50 ? true:false);
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Enter a Number: ");
            Double E = Convert.ToDouble(Console.ReadLine());
            Console.Write("{0} / 7 = {1} Remainder {2}", E, (long)E/7, E%7);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
