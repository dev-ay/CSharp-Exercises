using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validResponse = false;

            while (!validResponse)
            {
                try
                {
                    Console.Write("How old are you?  ");
                    validResponse = int.TryParse(Console.ReadLine(), out int age);
                    if (!validResponse) throw new AgeException("\nPlease enter numeric digits only, and no decimals.  Please try again...\n");
                    else if (age < 0)
                    {
                        validResponse = false;
                        throw new AgeException("\nYou have entered a negative number for age.  Please try again...\n");
                    }
                    else if (age == 0) throw new AgeException("\nYou have entered 0 for age.  Please try again...\n");
                    else
                    {
                        int now = DateTime.Now.Year;
                        Console.WriteLine("\nYou were born in the year " + (now - age));

                    }
                }
                catch (AgeException) { }
                catch (Exception)
                {
                    Console.WriteLine("\nSorry, something unexpected has occurred with the program.  Please contact your System Administrator.");
                }
                

            }

            Console.ReadLine();
        }
    }
}
