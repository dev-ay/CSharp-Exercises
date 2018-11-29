using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer to divide by 2: ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            Math m = new Math();
            int A = m.divide(dividend);
            Console.WriteLine("Return method: " + A);
            Console.WriteLine();

            int B;
            m.divide(dividend, out B);
            Console.WriteLine("Void method (overload): " + B);
            Console.WriteLine();

            int C = Math.Divide(dividend);
            Console.WriteLine("Static method: " + C);
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
