using System;
using System.Collections; //Necessary for Hashtable
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let\'s create a Hashtable HT.");
            Hashtable HT = new Hashtable();
            Console.WriteLine("\nWhat is the size of HT?: " + HT.Count);
            Console.WriteLine("\nLet\'s add movie details for Braveheart to HT.");
            HT.Add("Type","Movie");
            HT.Add("Title", "Braveheart");
            HT.Add("Director", "Mel Gibson");
            HT.Add("Year", 1995);
            HT.Add("Writer", "Randall Wallace");
            HT.Add("Oscars", 2);
            HT.Add("Rating", "R");
            HT.Add("Length", 178);
            HT.Add("Best Movie Ever",true);
            Console.WriteLine("\nNow what is the size of HT?:\t" + HT.Count);
            Console.WriteLine("\nLet\'s display the contents of HT...\n");
            Console.WriteLine("HT[\"Type\"]:\t" + HT["Type"]);
            Console.WriteLine("HT[\"Title\"]:\t" + HT["Title"]);
            Console.WriteLine("HT[\"Director\"]:\t" + HT["Director"]);
            Console.WriteLine("HT[\"Year\"]:\t" + HT["Year"]);
            Console.WriteLine("HT[\"Writer\"]:\t" + HT["Writer"]);
            Console.WriteLine("HT[\"Oscars\"]:\t" + HT["Oscars"]);
            Console.WriteLine("HT[\"Rating\"]:\t" + HT["Rating"]);
            Console.WriteLine("HT[\"Length\"]:\t" + HT["Length"]);
            Console.WriteLine("HT[\"Best Movie Ever\"]:\t" + HT["Best Movie Ever"]);

            Console.WriteLine("\nWhat is the data type of the value of HT[\"Title\"]?:  " + HT["Title"].GetType());
            Console.WriteLine("What is the data type of the value of HT[\"Oscars\"]?:  " + HT["Oscars"].GetType());
            Console.WriteLine("What is the data type of the value of HT[\"Best Movie Ever\"]?:  " + HT["Best Movie Ever"].GetType());
            Console.WriteLine("\nThus we see that a Hashtable does not care about the data type of the value it stores.");

            Console.Write("\nWhat are the keys of HT?");
            Console.Write("{ ");
            foreach(var x in HT.Keys)
            {
                Console.Write("\"" + x + "\" ");
            }
            Console.WriteLine("}");

            Console.Write("What are the values of HT?");
            Console.Write("{ ");
            foreach (var x in HT.Keys)
            {
                Console.Write("\"" + HT[x] + "\" ");
            }
            Console.WriteLine("}");

            Console.WriteLine("\nLet\'s remove the key \"Best Movie Ever\" and its associated value.");
            HT.Remove("Best Movie Ever");

            Console.WriteLine("\nNow what are the contents of HT? \n");
            Console.Write("KEYS    \tVALUES\n");
            Console.Write("----    \t------\n");
            foreach (var x in HT.Keys)
            {
                Console.WriteLine(x + ":    \t" + HT[x]);
            }

            Console.WriteLine("\nDoes HT contain the key \"Best Movie Ever\"?:  " + (HT.Contains("Best Movie Ever")?"Yes":"No") );
            Console.WriteLine("\nDoes HT contain the key \"Title\"?:  " + (HT.Contains("Title") ? "Yes" : "No"));

            Console.WriteLine("\nLet\'s make a clone of HT, into HTclone.");
            var HTclone = (Hashtable)HT.Clone();  //Shallow clone must be cast to Hashtable to be enumerable
            Console.WriteLine("\nWhat are the contents of HTclone? \n");
            Console.Write("KEYS    \tVALUES\n");
            Console.Write("----    \t------\n");
            foreach (var x in HTclone.Keys)
            {
                Console.WriteLine(x + ":    \t" + HTclone[x]);
            }

            Console.WriteLine("\nLet\'s clear HT.");
            HT.Clear();
            Console.WriteLine("\nNow what is the size of HT?:\t" + HT.Count);
            Console.ReadLine();
        }
    }
}
