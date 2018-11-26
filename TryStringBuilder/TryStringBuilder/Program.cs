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
            String B = "StringBuilder is a library tool created by Microsoft, ";
            String C = "using the C# language.";

            StringBuilder sb = new StringBuilder();

            sb.Append(A);
            sb.Append(B);
            sb.Append(C);

            Console.WriteLine(sb.ToString().ToUpper());

            Console.ReadLine();
        }
    }
}
