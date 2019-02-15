using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let\'s create sets, within the window 1 ~ 10, of integers, primes, odds, and evens.");
            HashSet<int> integers = new HashSet<int>();
            for (int i=1;i<=10;i++)
            {
                integers.Add(i);
            }
            HashSet<int> primes = new HashSet<int>();
            primes.Add(2);
            primes.Add(3);
            primes.Add(5);
            primes.Add(7);
            HashSet<int> odds = new HashSet<int>();
            for (int i = 1; i <= 10; i= i+2)
            {
                odds.Add(i);
            }
            HashSet<int> evens = new HashSet<int>();
            for (int i = 2; i <= 10; i=i+2)
            {
                evens.Add(i);
            }
            Console.WriteLine("\nIs primes a subset of integers?: " + (primes.IsSubsetOf(integers)?"Yes":"No"));
            Console.WriteLine("\nIs odds a subset of integers?: " + (odds.IsSubsetOf(integers) ? "Yes" : "No"));
            Console.WriteLine("\nIs evens a subset of integers?: " + (evens.IsSubsetOf(integers) ? "Yes" : "No"));
            Console.WriteLine("\nIs primes a subset of odds?: " + (primes.IsSubsetOf(odds) ? "Yes" : "No"));
            Console.WriteLine("\nDoes evens overlap with primes?: " + (evens.Overlaps(primes) ? "Yes" : "No"));
            Console.Write("\nWhich primes intersect with evens?: ");
            var temp = primes.Intersect(evens);
            Console.Write("[ ");
            foreach (int t in temp)
            {
                Console.Write(t + " ");
            }
            Console.WriteLine("]");

            Console.Write("\nWhich primes intersect with odds?: ");
            temp = primes.Intersect(odds);
            Console.Write("[ ");
            foreach (int t in temp)
            {
                Console.Write(t + " ");
            }
            Console.WriteLine("]");

            Console.Write("\nWhat results from evens in union with primes?: ");
            temp = primes.Union(evens);
            Console.Write("[ ");
            foreach (int t in temp)
            {
                Console.Write(t + " ");
            }
            Console.WriteLine("]");

            Console.Write("\nWhat is the difference between that and integers?: ");
            temp = integers.Except(primes.Union(evens));
            Console.Write("[ ");
            foreach (int t in temp)
            {
                Console.Write(t + " ");
            }
            Console.WriteLine("]");

            Console.Write("\nIs the union of evens and odds a proper subset of integers?: ");
            temp = evens.Union(odds);
            Console.Write(integers.IsProperSupersetOf(temp));



            Console.ReadLine();
        }
    }
}
 