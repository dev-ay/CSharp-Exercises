using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTA_DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine();
            Console.Write("What course are you on? >>>  ");
            String course = Console.ReadLine();
            Console.Write("What page number? >>>  ");
            String page = Console.ReadLine();
            Console.Write("Do you need help with anything? Please answer \"true\" or \"false\". >>>  ");
            Boolean help = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Were there any positive experiences you'd like to share?  Please give specifics. >>>  ");
            String positiveExperience = Console.ReadLine();
            Console.Write("Is there any other feeback you'd like to provide?  Please be specific. >>>  ");
            String feedback = Console.ReadLine();
            Console.Write("How many hours did you study today? >>>  ");
            byte hours = Convert.ToByte(Console.ReadLine() );
            Console.WriteLine();
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly.  Have a great day!");
            Console.Read();
            
        }
    }
}
