using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let\'s create a queue Q.");
            Queue<int> Q = new Queue<int>();
            Console.WriteLine("\nWhat is the size of Q?: " + Q.Count);
            Console.WriteLine("\nLet\'s enqueue the numbers 1 through 5. ");
            Q.Enqueue(1);
            Q.Enqueue(2);
            Q.Enqueue(3);
            Q.Enqueue(4);
            Q.Enqueue(5);
            Console.WriteLine("\nWhat is the size of Q?: " + Q.Count);
            Console.WriteLine("\nLet\'s peek at Q: " + Q.Peek());
            Console.WriteLine("\nNow what is the size of Q?: " + Q.Count);
            Console.WriteLine("\nLet\'s dequeue Q: " + Q.Dequeue());
            Console.WriteLine("\nWhat is the size of Q?: " + Q.Count);
            Console.WriteLine("\nLet\'s copy the contents of Q to an integer array A.");
            int[] A = Q.ToArray();
            Console.Write("\nWhat are the contents of A?:  ");
            Console.Write("[ ");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i]+" ");
            }
            Console.WriteLine("]");
            Console.WriteLine("\nIt appears that a Queue copies data to an array in forward order.");
            //Q.Enqueue();
            Console.WriteLine("\nDoes Q contain the number 2?: " + (Q.Contains(2) ? "Yes": "No"));
            Console.WriteLine("\nLet\'s clear Q.");
            Q.Clear();
            Console.WriteLine("\nNow what is the size of Q?: " + Q.Count);
            Console.ReadLine();
        }
    }
}
