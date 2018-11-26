using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceApproval
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Car Insurance Application");
            Console.WriteLine();
            Console.Write("What is your age?  ");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.Write("Have you ever had a DUI (True or False)?  ");
            bool DUI = Convert.ToBoolean(Console.ReadLine());
            Console.Write("How many speeding tickets do you have?  ");
            byte tickets = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Are you qualified?");
            Console.WriteLine("  --> " + ((age > 15 && !DUI && tickets <= 3) ? "Yes" : "No") );

            Console.ReadLine();
        }
    }
}
