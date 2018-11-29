using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find out how much money will be in your bank account in a year excluding expenses...");
            Console.WriteLine();
            Console.Write("Enter your income hourly rate in whole numbers: ");
            int rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter how much money is currently in your bank account in whole numbers (optional): ");
            string savings = Console.ReadLine();

            Math x = new Math();
            int total;
            if(savings == "")
            {
                total = x.PiggyBank(rate);
            }
            else
            {
                total = x.PiggyBank(rate, Convert.ToInt32(savings));
            }

            Console.WriteLine();
            Console.WriteLine("In a year you will have {0:C} in your bank account",total);


            Console.ReadLine();
        }
    }
}
