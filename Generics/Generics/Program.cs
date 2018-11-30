using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> A = new Employee<string>();
            A.Things = new List<string>() { "Muffin", "Cookie", "Doughnut", "Pie" };
            Console.WriteLine("Things that Employee A owns:");
            foreach (string x in A.Things)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine();
            Console.WriteLine();

            Employee<int> B = new Employee<int>();
            B.Things = new List<int>() { 100, 200, 300, 400 };
            Console.WriteLine("Things that Employee B owns:");
            foreach (int x in B.Things)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
