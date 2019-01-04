using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given an array of integers, write a method to total the odd numbers

            //Array of integers
            int[] Array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            //Add all odd numbers
            int Sum = 0;
            for(int i=0; i < Array.Length; i++)
            {
                if(Array[i] % 2 == 1)
                {
                    Sum += Array[i];
                }
                
            }
            Console.WriteLine(Sum);

            Console.ReadLine();
        }
    }
}
