using System;
using System.Collections.Generic;


namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int>() { 0, 1, 2, 3, 10, 11, 77, 100, 1357 };

            Console.WriteLine("List of numbers:");
            Console.Write("[ ");
            foreach(int element in integers)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("]");
            Console.WriteLine();


                Console.Write("Please provide an integer divisor for each number from list: ");
                string divisor = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("The list of numbers divided by " + divisor + " is:");
                Console.WriteLine();

            try
            {
                

                Console.Write("[ ");
                foreach (int element in integers)
                {
                    //Console.Write(Convert.ToSingle(element) / Convert.ToSingle(divisor) + " ");
                    Console.Write(element / Convert.ToInt32(divisor) + " ");
                }
                //Console.WriteLine("]");
            }
            catch(OverflowException ex)
            {
                Console.Write("Error: The number you entered was too large. ");
            }
            catch(DivideByZeroException ex)
            {
                Console.Write("Error: You cannot divide by 0. ");
            }
            catch(FormatException ex)
            {
                Console.Write("Error: You did not enter a valid integer. ");
            }
            catch(Exception ex)
            {
                Console.Write("Error: " + ex.Message + " ");
            }
            finally
            {
                Console.WriteLine("]");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Exited Try/Catch block");

            Console.ReadLine();
        }
    }
}
