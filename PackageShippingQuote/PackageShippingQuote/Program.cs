using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageShippingQuote
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express.  Please follow the instructions below.");
            Console.WriteLine();

            Console.Write("How much does the package weight? ");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (weight > 50)
            {
                Console.WriteLine("This package is too heavy to be shipped via Package Express.  Have a good day.");
                Console.ReadLine();
                return;
            }

            Console.Write("What is the package width? ");
            float width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("What is the package height? ");
            float height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("What is the package length? ");
            float length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            float dimensions = width + height + length;
            if (dimensions > 50)
            {
                Console.WriteLine("This package is too big to be shipped via Package Express.  Have a good day.");
                Console.ReadLine();
                return;
            }

            double quote = dimensions * weight / 100;

            Console.WriteLine("Your estimated total for shipping this package is: {0:C}", quote);
            Console.WriteLine();
            Console.Write("Thank you.");

            Console.ReadLine();
        }
    }
}
