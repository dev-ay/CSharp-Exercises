using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person
    {
        public string FirstName;
        public string LastName;


        //public void person(string first, string last)
        //{
        //    FirstName = first;
        //    LastName = last;
        //}

        public void SetName(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }


        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
