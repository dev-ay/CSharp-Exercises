using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChaining
{
    class Program
    {
        static void Main(string[] args)
        {
            const float pi_float = 3.14159f;
            var pi_Var = 3.14159;

            Console.WriteLine("\"pi_float\" type: " + pi_float.GetType());
            Console.WriteLine("\"pi_Var\" type: " + pi_Var.GetType());
            Console.WriteLine();

            Circle Earth = new Circle(3960);
            Console.WriteLine("Earth's radius is approximately: " + Earth.radius + " miles");
            Console.WriteLine("Earth's diameter is approximately: " + Earth.diameter + " miles");
            Console.WriteLine("Earth's circumference is approximately: " + 2 * pi_Var * Earth.radius + " miles");
            Console.ReadLine();
        }
    }
}
