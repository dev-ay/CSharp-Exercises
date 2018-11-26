using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathCompare
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine();

            Console.WriteLine("Person 1:");
            Console.Write("  --> Hourly Rate? ");
            float P1rate = Convert.ToSingle(Console.ReadLine());
            Console.Write("  --> Hours Worked Per Week? ");
            byte P1hours= Convert.ToByte(Console.ReadLine());
            Console.WriteLine();
           
            Console.WriteLine("Person 2:");
            Console.Write("  --> Hourly Rate? ");
            float P2rate = Convert.ToSingle(Console.ReadLine());
            Console.Write("  --> Hours Worked Per Week? ");
            byte P2hours = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();

            float P1annual = P1rate * P1hours * 52;
            float P2annual = P2rate * P2hours * 52;

            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine("  --> {0:C}", P1annual);
            Console.WriteLine();

            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine("  --> {0:C}", P2annual);
            Console.WriteLine();

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine("  --> " + (P1annual > P2annual ? true : false));

            Console.ReadLine();

        }
    }
}
