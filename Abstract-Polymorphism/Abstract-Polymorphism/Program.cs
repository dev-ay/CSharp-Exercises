using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee X = new Employee() { FirstName = "Sample", LastName = "Student" };
            X.SayName();
            Console.ReadLine();
        }
    }
}
