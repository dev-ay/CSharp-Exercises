using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee A = new Employee() { ID = 123456 };
            Employee B = new Employee() { ID = 123456 };

            Console.WriteLine("Does Employee A have the same ID as Employee B?: ");
            Console.WriteLine();
            Console.WriteLine( A == B );
            Console.ReadLine();

        }
    }
}
