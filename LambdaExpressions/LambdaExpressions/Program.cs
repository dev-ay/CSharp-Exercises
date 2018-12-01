using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee() { FirstName = "Jon", LastName = "Smith", ID = 1 } );
            list.Add(new Employee() { FirstName = "Joe", LastName = "Miller", ID = 2 });
            list.Add(new Employee() { FirstName = "Jane", LastName = "Taylor", ID = 3 });
            list.Add(new Employee() { FirstName = "Joe", LastName = "Buckley", ID = 4 });
            list.Add(new Employee() { FirstName = "Sam", LastName = "Washington", ID = 5 });
            list.Add(new Employee() { FirstName = "Jessica", LastName = "Adams", ID = 6 });
            list.Add(new Employee() { FirstName = "Tiffany", LastName = "Johnson", ID = 7 });
            list.Add(new Employee() { FirstName = "Mike", LastName = "Williams", ID = 8 });
            list.Add(new Employee() { FirstName = "Sidney", LastName = "Taylor", ID = 9 });
            list.Add(new Employee() { FirstName = "Joe", LastName = "Robinson", ID = 10 });


            //Find all employees named "Joe" using foreach
            List<Employee> list2 = new List<Employee>();

            foreach(Employee e in list)
            {
                if(e.FirstName == "Joe")
                {
                    list2.Add(e);
                }
            }

            Console.WriteLine("Find all employees named \"Joe\" using foreach:");
            foreach (Employee e in list2)
            {
                Console.WriteLine(e.FirstName + " " + e.LastName + ", ID = " + e.ID);
            }
            Console.WriteLine();
            Console.WriteLine();


            //Find all employees named "Joe" using lambda expressions
            List<Employee> list3 = list.Where(x => x.FirstName == "Joe").ToList();

            Console.WriteLine("Find all employees named \"Joe\" using lambda expressions:");
            foreach (Employee e in list3)
            {
                Console.WriteLine(e.FirstName + " " + e.LastName + ", ID = " + e.ID);
            }

            Console.WriteLine();
            Console.WriteLine();


            //Find all employees with ID greater than 5 using lambda expressions
            List<Employee> list4 = list.Where(x => x.ID > 5).ToList();
            Console.WriteLine("Find all employees with ID greater than 5 using lambda expressions:");
            foreach (Employee e in list4)
            {
                Console.WriteLine(e.FirstName + " " + e.LastName + ", ID = " + e.ID);
            }

            Console.ReadLine();

        }
    }
}
