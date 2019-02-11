using System;
using System.Collections; //Necessary for ArrayList
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList AL = new ArrayList();
            Console.WriteLine("Let's create a new ArrayList AL...");
            Console.WriteLine("\nWhat is the size of AL?: " + AL.Capacity + " ... # of Entries?: " + AL.Count);
            Console.WriteLine("\nLet\'s add one entry \"One\"");
            AL.Add("One");
            Console.WriteLine("\nNow what is the size of AL?: " + AL.Capacity + " ... # of Entries?: " + AL.Count);
            Console.WriteLine("\nLet\'s add 3 more entries \"Two\", 3, and 4");
            AL.Add("Two");
            AL.Add(3);
            AL.Add(4);
            Console.WriteLine("\nNow what is the size of AL?: " + AL.Capacity + " ... # of Entries?: " + AL.Count);
            Console.WriteLine("\nLet\'s add one more entry, true: ");
            AL.Add(true);
            Console.WriteLine("\nNow what is the size of AL?: " + AL.Capacity + " ... # of Entries?: " + AL.Count);
            Console.WriteLine("\nSo far we see that ArrayList double in size each time it grows. ");
            Console.WriteLine("\nIn addition, we have been able to add entries of different data types, string, integer, and boolean. ");
            Console.WriteLine("\nLet\'s double check: ");
            Console.WriteLine("\nWhat is the first entry of AL and what is it's type?: " + AL[0] + " ... type: " +AL[0].GetType());
            Console.WriteLine("\nWhat is the third entry of AL and what is it's type?: " + AL[2] + " ... type: " + AL[2].GetType());
            Console.WriteLine("\nWhat is the fifth entry of AL and what is it's type?: " + AL[4] + " ... type: " + AL[4].GetType());
            Console.WriteLine("\nDoes AL contain a boolean true?: " + (AL.Contains(true) ? "Yes" : "No") );
            Console.WriteLine("\nWhat is the index of the boolean true?: " + AL.IndexOf(true));
            Console.WriteLine("\nLet\'s remove the entry \"Two\".");
            AL.RemoveAt(1);
            Console.WriteLine("\nNow what is the size of AL?: " + AL.Capacity + " ... # of Entries?: " + AL.Count);
            Console.WriteLine("\nWhat is the second entry of AL and what is it's type?: " + AL[1] + " ... type: " + AL[1].GetType());
            Console.WriteLine("\nLet\'s remove the 2nd and 3rd entries.");
            AL.RemoveRange(1,2);
            Console.WriteLine("\nNow what is the size of AL?: " + AL.Capacity + " ... # of Entries?: " + AL.Count);
            Console.WriteLine("\nLet\'s remove the first instance of the boolean true.");
            AL.Remove(true);
            Console.WriteLine("\nNow what is the size of AL?: " + AL.Capacity + " ... # of Entries?: " + AL.Count);
            Console.WriteLine("\nWhat is the first and only entry of AL and what is it's type?: " + AL[0] + " ... type: " + AL[0].GetType());
            Console.WriteLine("\nLet\'s clear AL.");
            AL.Clear();
            Console.WriteLine("\nNow what is the size of AL?: " + AL.Capacity + " ... # of Entries?: " + AL.Count);
            Console.WriteLine("\nLet\'s add the numbers 1 through 5 back into AL. ");
            AL.AddRange(new int[] { 5, 4, 3, 2, 1 });
            Console.WriteLine("\nNow what is the size of AL?: " + AL.Capacity + " ... # of Entries?: " + AL.Count);
            Console.WriteLine("\nWhat is the fifth entry of AL and what is it's type?: " + AL[4] + " ... type: " + AL[4].GetType());
            Console.WriteLine("\nLet\'s sort AL.");
            AL.Sort();
            Console.WriteLine("\nNow what is the fifth entry of AL and what is it's type?: " + AL[4] + " ... type: " + AL[4].GetType());
            Console.WriteLine("\nLet\'s trim AL.");
            AL.TrimToSize();
            Console.WriteLine("\nNow what is the size of AL?: " + AL.Capacity + " ... # of Entries?: " + AL.Count);
            Console.WriteLine("\nLet\'s add 6 to AL.");
            AL.Add(6);
            Console.WriteLine("\nNow what is the size of AL?: " + AL.Capacity + " ... # of Entries?: " + AL.Count);
            Console.WriteLine("\nWe notice that you can trim empty spaces off of the ArrayList backing store.  " +
                "\nWe also see that ArrayList growth will always double whatever the current size of the backing store.");
            Console.ReadLine();
            
        }
    }
}
