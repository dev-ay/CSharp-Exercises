using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let\'s create a stack S.");
            Stack<int> S = new Stack<int>();
            Console.WriteLine("\nWhat is the size of S?: " + S.Count);
            Console.WriteLine("\nLet\'s push numbers 1 through 5.");
            S.Push(1);
            S.Push(2);
            S.Push(3);
            S.Push(4);
            S.Push(5);
            Console.WriteLine("\nNow what is the size of S?: " + S.Count);
            Console.WriteLine("\nLet\'s peek the stack: " + S.Peek());
            Console.WriteLine("\nNow what is the size of S?: " + S.Count);
            Console.WriteLine("\nLet\'s pop the stack: " + S.Pop());
            Console.WriteLine("\nNow what is the size of S?: " + S.Count);
            Console.WriteLine("\nDoes the current object of S equal the number 4?: " + (S.Equals(4)?"Yes":"No"));
            Console.WriteLine("\nLet\'s transfer the stack to an integer array A.");
            int[] A = S.ToArray();
            Console.Write("\nWhat is contained in A?:  ");
            Console.Write("[ ");
            for(int i = 0; i<A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine("]");
            Console.WriteLine("\nLet\'s create an empty integer array B of size 4 and copy to it contents of S.");
            int[] B = new int[4];
            S.CopyTo(B,0);
            Console.Write("\nWhat is contained in B?:  ");
            Console.Write("[ ");
            for (int i = 0; i < B.Length; i++)
            {
                Console.Write(B[i] + " ");
            }
            Console.WriteLine("]");
            Console.WriteLine("\nWe see that when copying the stack to an array, the copying is done in reverse order.");
            //S.Push();

            Console.ReadLine();
        }
    }
}
