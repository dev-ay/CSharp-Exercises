using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_DoWhile
{
    class Program
    {
        static void Main()
        {

            
            Console.WriteLine("*******************    Prime # demo using While loop    *******************");
            string guess = "";

            while (guess != "Q")
            {
                Console.Write("Guess a number between 1 and 10 to see if it is prime (Enter Q to quit): ");
                guess = Console.ReadLine();

                switch (guess)
                {
                    case "Q":
                        break;
                    case "1":
                        Console.WriteLine("Nice try, but 1 is a unit number, not a prime number.");
                        break;
                    case "2":
                        Console.WriteLine("Yes, 2 is a prime number.");
                        break;
                    case "3":
                        Console.WriteLine("Yes, 3 is a prime number.");
                        break;
                    case "5":
                        Console.WriteLine("Yes, 5 is a prime number.");
                        break;
                    case "7":
                        Console.WriteLine("Yes, 7 is a prime number.");
                        break;
                    default:
                        Console.WriteLine("No, {0} is not a prime number.", guess);
                        break;
                }
                Console.WriteLine("");
            }






            Console.WriteLine("");




            Console.WriteLine("******************    Prime # demo using Do-While loop    *****************");
            guess = "";

            do
            {
                Console.Write("Guess a number between 1 and 10 to see if it is prime (Enter Q to quit): ");
                guess = Console.ReadLine();

                switch (guess)
                {
                    case "Q":
                        break;
                    case "1":
                        Console.WriteLine("Nice try, but 1 is a unit number, not a prime number.");
                        break;
                    case "2":
                        Console.WriteLine("Yes, 2 is a prime number.");
                        break;
                    case "3":
                        Console.WriteLine("Yes, 3 is a prime number.");
                        break;
                    case "5":
                        Console.WriteLine("Yes, 5 is a prime number.");
                        break;
                    case "7":
                        Console.WriteLine("Yes, 7 is a prime number.");
                        break;
                    default:
                        Console.WriteLine("No, {0} is not a prime number.", guess);
                        break;
                }
                Console.WriteLine("");

            }
            while (guess != "Q");



                    Console.WriteLine("");

            Console.ReadLine();


        }
    }
}
