using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] months = { "January", "February", "March",
            "April", "May", "June", "July", "August", "September",
            "October", "November", "December"};

            LinkedList<String> Months = new LinkedList<string>();

            for(int i = 0; i < months.Length; i++)
            {
                Months.AddLast(months[i]);
            }

            Console.WriteLine("Let's construct a Linked List Months... ");
            Console.Write("\nHow many nodes are in Months?: ");
            Console.WriteLine(Months.Count);
            Console.Write("\nFirst node of Months: ");
            Console.WriteLine(Months.First.Value);
            Console.Write("\nLast node of Months: ");
            Console.WriteLine(Months.Last.Value);
            Console.Write("\nDoes Months contain August?: ");
            Console.WriteLine(Months.Contains("August") ? "Yes" : "No");
            Console.Write("\nWhat comes after July?: ");
            Console.WriteLine(Months.Find("July").Next.Value);
            Console.WriteLine("\nLet's change August to August123... ");
            Months.Find("August").Value = "August123";
            Console.Write("\nNow does Months contain August?: ");
            Console.WriteLine(Months.Contains("August") ? "Yes" : "No");
            Console.Write("\nNow what comes after July?: ");
            Console.WriteLine(Months.Find("July").Next.Value);
            Console.WriteLine("\nLet's add the word Summer after July");
            Months.AddAfter(Months.Find("July"),"Summer");
            Console.Write("\nNow what comes after July?: ");
            Console.WriteLine(Months.Find("July").Next.Value);
            Console.Write("\nNow how many nodes are in Months?: ");
            Console.WriteLine(Months.Count);
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Now for the final exercise, \n" +
                "think of a sentence and enter each word at a time.  \n" +
                "At the end we will return to you an array full of your words. \n" +
                "Enter STOP when you are done:\n");
            LinkedList<String> sentence = new LinkedList<String>();
            String word;
            while(true)
            {
                Console.Write("Enter a word: ");
                word = Console.ReadLine();
                if (word == "STOP") break;
                else sentence.AddLast(word);
                //(word == "STOP")? break : sentence.AddLast(word);
            }
                
            String[] Sentence = new string[sentence.Count];
            sentence.CopyTo(Sentence,0);
            Console.Write("[ ");
            for(int i = 0; i < Sentence.Length; i++)
            {
                Console.Write(Sentence[i] + " ");
            }
            Console.WriteLine(" ]");
            Console.ReadLine();
            
        }
    }
}
