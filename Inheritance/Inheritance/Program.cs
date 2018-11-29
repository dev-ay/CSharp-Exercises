using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person employee = new Person("Sample","Student");
            Employee employee = new Employee();
            //employee.FirstName = "Sample";
            //employee.LastName = "Student";
            employee.SetName("Sample","Student");
            employee.SayName();

            Console.ReadLine();
        }
    }
}
