using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            //GAME OF FIZZBUZZ

            //Ask user how high to count
            Console.Write("Enter the termination number for FizzBuzz: ");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //Boolean representing either Fizz and/or Buzz found
            bool fb = false; 

            for(int i = 1; i <= end; i++)
            {

                //Print "Fizz"
                if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                    fb = true;
                }

                //Print "Buzz"
                if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                    fb = true;
                }

                //If neither Fizz nor Buzz, print number
                if (fb == false)
                {
                    Console.Write(i);
                }

                //Reset fb to false for next number
                fb = false;

                //Insert commas or ellipsis
                if (i < end) Console.Write(", ");
                else Console.Write("...");
            }

            Console.ReadLine();
        }
    }
}
