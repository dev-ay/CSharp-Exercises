using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given a string, reverse it. 

            //String
            string s = "Hello World";

            //Reverse String
            char[] r = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                r[i] = s[(s.Length - i - 1)];
            }
            string reverse = new string(r);


            Console.WriteLine(reverse);

            Console.ReadLine();

        }
    }
}
