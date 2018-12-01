using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {

            //Enum.TryParse(Console.ReadLine(), out DaysOfWeek input);
            bool retry = true;
            while (retry)
            {
                try
                {
                    Console.Write("Please enter a day of the week (Capitalize the first letter): ");
                    DaysOfWeek input = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("You entered: " + input);
                    Console.WriteLine();
                    retry = false;

                }
                catch (Exception E)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter an actual day of the week.");
                    Console.WriteLine();
                }

            }






            Console.ReadLine();
        }
    }

    public enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
