using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddLargeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given an array of integers, write a method to sum the elements in the array, 
            //  knowing that some of the elements may be very large integers

            //Array of integers
            int[] Array = new int[] 
            { 100000000,
              200000000,
              300000000,
              400000000,
              500000000,
              600000000,
              700000000,
              800000000,
              900000000,
              1000000000,
            };

            //Add integers
            ulong sum = 0;

            for(int i=0; i < Array.Length; i++)
            {
                sum += (ulong)Array[i];
            }

            Console.WriteLine("{0:n0}",sum);

            Console.ReadLine();

        }
    }
}
