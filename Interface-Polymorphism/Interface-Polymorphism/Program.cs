using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //The "Employee" class implements interface IQuittable and inherits from abstract class "Person"
            //The following instantiates an Employee object as an IQuittable type
            //The IQuittable object does not inherit any properties or methods from abstract class "Person"
            //However, it does retain the implementation of the Quit method from child class "Employee"
            IQuittable x = new Employee();
            x.Quit();
            Console.ReadLine();


            //Employee x = new Employee() { FirstName = "Sample", LastName = "Student" };
            //x.SayName();
            //x.Quit();
            //x.SayName();
            //Console.ReadLine();
        }
    }
}
 