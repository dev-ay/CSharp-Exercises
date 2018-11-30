using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Employee : Person
    {
        public int ID;
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        public static bool operator==(Employee A, Employee B)
        {
            return A.ID == B.ID ? true : false;
        }

        public static bool operator !=(Employee A, Employee B)
        {
            return A.ID != B.ID ? true : false;
        }
    }
}
