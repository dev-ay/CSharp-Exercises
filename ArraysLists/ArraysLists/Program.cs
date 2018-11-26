using System;
using System.Collections.Generic;


namespace ArraysLists
{
    class Program
    {
        static void Main()
        {
            //Create an Array of the 1st 10 Presidents and ask the user to provide the index
            String[] presidents = { "George Washington","John Adams",
                "Thomas Jefferson","James Madison","James Monroe",
                "John Quincy Adams","Andrew Jackson","Martin Van Buren",
                "William Henry Harrison","John Tyler"};

            
            Console.Write("Enter a number betweeen 1 and 10 to see the first 10 Presidents: ");
            int GuessPresident = Convert.ToInt32(Console.ReadLine());

            while (GuessPresident < 0 || GuessPresident > 10)
            {
                Console.Write("The number you entered is invalid.  Please enter a number between 1 and 10: ");
                GuessPresident = Convert.ToInt32(Console.ReadLine());
            };

            Console.WriteLine();
            Console.WriteLine("President #" + GuessPresident + " is " + presidents[GuessPresident-1]);
            Console.WriteLine();
            Console.WriteLine();


            //Create an Array of the 1st 10 prime numbers and ask the user to provide the index
            int[] primes = new int[] {2,3,5,7,11,13,17,19,23,29};
            Console.Write("Enter a number betweeen 1 and 10 to see the first 10 prime numbers: ");
            int GuessPrime = Convert.ToInt32(Console.ReadLine());
            while(GuessPrime < 0 || GuessPrime > 10)
            {
                Console.Write("The number you entered is invalid.  Please enter a number between 1 and 10: ");
                GuessPrime = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Prime #" + GuessPrime + " is " + primes[GuessPrime - 1]);
            Console.WriteLine();
            Console.WriteLine();



            //Create a List of the 1st 10 Presidents and ask the user to provide the index
            List<String> PresidentList = new List<string>();

            for(int i = 0; i < 10; i++)  //populate list using presidents array from earlier
            {
                PresidentList.Add(presidents[i]);
            }


            Console.Write("Again, enter a number betweeen 1 and 10 to see the first 10 Presidents: ");
            int GuessPresidentList = Convert.ToInt32(Console.ReadLine());

            while (GuessPresidentList < 0 || GuessPresidentList > 10)
            {
                Console.Write("The number you entered is invalid.  Please enter a number between 1 and 10: ");
                GuessPresidentList = Convert.ToInt32(Console.ReadLine());
            };

            Console.WriteLine();
            Console.WriteLine("President #" + GuessPresidentList + " is " + PresidentList[GuessPresidentList - 1]);
            Console.WriteLine();
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
