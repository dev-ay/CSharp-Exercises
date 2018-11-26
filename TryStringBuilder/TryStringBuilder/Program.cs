using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryStringBuilder
{
    class Program
    {
        static void Main()
        {
            String A = "Hi! ";
            String B = "StringBuilder is a library tool created by Microsoft using the C# language. ";
            String C = "It allows for the efficient modification of String variables.";

            StringBuilder sb = new StringBuilder();

            sb.Append(A);
            sb.Append(B);
            sb.Append(C);

            Console.WriteLine(sb.ToString().ToUpper());

            Console.ReadLine();
        }
    }
}
