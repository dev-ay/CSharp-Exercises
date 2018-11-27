using System;
using System.Collections.Generic;


namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create a one-dimensional Array of strings. Ask the user to input some text. 
            //      Create a loop that goes through each string in the Array, adding the user’s text to the string. 
            //      Then create a loop that prints off each string in the Array on a separate line.
            Console.Write("Please enter any text: ");
            string input = Console.ReadLine();
            Console.WriteLine();
            string[] text = {"Array element 1: \"", "Array element 2: \"", "Array element 3: \"" , "Array element 4: \"" , "Array element 5: \"" };
            for(int j = 0; j < text.Length; j++)
            {
                text[j] = text[j] + input + "\"";
            }
            for (int j = 0; j < text.Length; j++)
            {
                Console.WriteLine(text[j]);
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();




            //2.Create an infinite loop.
            //3.Fix the infinite loop so it will execute.
            for(int j=0; ; j++)
            {
                if (j == 1000)
                {
                    Console.WriteLine("Quit infinite loop.");
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();




            //4.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator. 
            Console.WriteLine("Numbers < 10 starting at 0:");
            for (int j=0; j<10; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();




            //5.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
            Console.WriteLine("Numbers <= 10 starting at 0:");
            for (int j = 0; j <= 10; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();




            //6.Create a List of strings where each item in the list is unique.  Ask the user to select text to search for in the List.
            //      Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.
            //7.Add code to that above loop that tells a user if they put in text that isn’t in the List. 
            //8.Add code to that above loop that stops it from executing once a match has been found. 

            string[] states = {"Delaware", "Pennsylvania","New Jersey",
            "Georgia","Connecticut","Massachusetts","Maryland","South Carolina",
            "New Hampshire","Virginia","New York","North Carolina","Rhode Island"};

            Console.Write("Enter a state to see if it was one of the first 13 (capitalize first letters): ");
            string GuessState = Console.ReadLine();
            Console.WriteLine();
            int i;
            for(i = 0; i < states.Length; i++)
            {
                if (states[i] == GuessState) {
                    break;
                }
            }
            if(i == states.Length)
            {
                Console.WriteLine("The state you entered was not among the first 13, or it was mispelled.");
            }
            else
            {
                Console.WriteLine(GuessState + " was the #" + (i+1) + " state to join the union.");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();




            //9.Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List.
            //      Create a loop that iterates through the list and then displays the indices of the array that contain matching text on the screen.
            //10.Add code to that above loop that tells a user if they put in text that isn’t in the List. 
            List<string> days = new List<string>() {"31","28","31","30","31","30","31","31","30","31","30","31"};            
            Boolean match = false;

            Console.Write("Enter a number of days in the month to see which months in 2019 have that many days (i.e. 28, 30, 31): ");
            String GuessDays = Console.ReadLine();
            Console.WriteLine();
            Console.Write("The following months have " + GuessDays + " days:  ");

            for (int month = 1; month<=12; month++)
            {
                if(days[month-1] == GuessDays)
                {
                    Console.Write(month + ", ");
                    match = true;
                }
            }

            if (!match)
            {
                Console.WriteLine("(there are no months with " + GuessDays + " days)");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();
            



            //11. Create a List of strings that has at least two identical strings in the List. Create a foreach loop that evaluates each item in the list, 
            //      and displays a message showing the string and whether or not it has already appeared in the list. 

            Console.WriteLine("Check whether milk is on the grocery list:");
            List<string> groceries = new List<string>();
            groceries.Add("Milk");
            groceries.Add("Oatmeal");
            groceries.Add("Orages");
            groceries.Add("Milk");
            groceries.Add("Ice cream bars");
            groceries.Add("Baking Soda");
            groceries.Add("Cheese");
            groceries.Add("Yogurt");
            groceries.Add("Milk");
            int counter = 0;
            foreach(string Guess in groceries)
            {
                if(Guess == "Milk")
                {
                    counter++;
                    if (counter == 1)
                    {
                        Console.WriteLine("\t--> " + Guess);
                    } else if (counter > 1)
                    {
                        Console.WriteLine("\t--> " + "Milk is already on the list");
                    }
                }
            }


            Console.ReadLine();
        }
    }
}
