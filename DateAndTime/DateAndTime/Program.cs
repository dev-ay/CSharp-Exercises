using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The date and time currently is :  ");
            DateTime now = DateTime.Now;
            Console.WriteLine(now + "\n");
            Console.Write("Enter an offset in hours to see what date it will be: ");
            double offset = Convert.ToDouble(Console.ReadLine());
            DateTime newTime = now.AddHours(offset);
            Console.WriteLine("\nIn " + offset + " hours it will be: " + newTime);

            Console.ReadLine();
        }
    }
}
