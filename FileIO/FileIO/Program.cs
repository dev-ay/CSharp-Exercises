using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to be logged to a file: ");
            string response = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Student\Desktop\GitHub\CSharp-Exercises\FileIO\FileIO\log.txt", response);

            /*
            using (StreamWriter file = new StreamWriter(@"C:\Users\Student\Desktop\GitHub\CSharp-Exercises\FileIO\FileIO\log.txt", false))
            {
                file.WriteLine(response);
            }
            */

            Console.Write("\nAccording to the log file, the number you provided was: ");
            string log = File.ReadAllText(@"C:\Users\Student\Desktop\GitHub\CSharp-Exercises\FileIO\FileIO\log.txt");
            Console.WriteLine(log);

            Console.ReadLine();
        }
    }
}
