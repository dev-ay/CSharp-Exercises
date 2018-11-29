using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Op x = new Op();
            Console.Write("Enter a number to double: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(A + " * 2 = " + x.Operate(A));
            Console.WriteLine();

            Console.Write("Enter a decimal number to round up: ");
            decimal B = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(B + " rounds up to " + x.Operate(B));
            Console.WriteLine();

            Console.Write("Enter the numbers 1-5 in capitalized words as the power to 10: ");
            string C = Console.ReadLine();
            int result = x.Operate(C);
            if(result == -1)
            {
                Console.WriteLine("You did not provide a valid entry.");
            }
            else
            {
                Console.WriteLine("10 to the power of " + C + " is " + result);
            }
            
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
