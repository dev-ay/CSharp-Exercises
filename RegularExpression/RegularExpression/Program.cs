using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; //Necessary for regular expressions

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let\'s create a string \"This  is   a  test...\"");
            Console.WriteLine("\nNotice our string has a series of 2 spaces, followed by a series of 3 spaces, and then a series of 2 spaces.");
            Console.WriteLine("\nUsing Regular Expressions, let\'s find the places with exactly 2 spaces.");
            String text = "This  is   a  test...";
            String pattern = @"[^ ]  [^ ]"; //or "[^ ][ ][ ][^ ]" or "[ ]{2}" or "\S\s\s\S"
            var results = Regex.Matches(text, pattern);
            Console.WriteLine("\nNumber of places with exactly 2 (only) spaces found: " + results.Count);
            Console.WriteLine("\nLet\'s mark the places where this occurs by replacing spaces with _:");
            var newText = Regex.Replace(text, @"(?<start>[^ ])  (?<end>[^ ])", @"${start}__${end}");
            Console.WriteLine("\n\""+newText + "\"");
            Console.WriteLine("\nSUCCESS!!!");
            Console.WriteLine("\nNow let\'s replace all instances of multiples spaces with 1 space:");

            //Notice that the following does not work because once a letter has been processed for <end>, it is no longer considered for <start>
            //Console.WriteLine("\n" + Regex.Replace(text, @"(?<start>[^ ])[ ]{2,}(?<end>[^ ])", @"${start} ${end}"));  

            Console.WriteLine("\n\"" + Regex.Replace(text, @"[ ]{2,}", " ") + "\"");

            Console.WriteLine("\n\nNow let\'s try a longer passage:");
            Console.ReadLine();
            string passage = 
                "\n\"When in the  Course of human events it becomes necessary for one people " +
                "\nto dissolve the political bands which have connected them with another " +
                "\nand to assume among the powers of the earth,  the separate and equal station " +
                "\nto which the  Laws of Nature  and of Nature's God entitle them, a decent respect " +
                "\nto the opinions of mankind requires that they should declare the causes which " +
                "\nimpel them to the separation." +
                "\n\nWe hold these truths to be self-evident, that all men are created equal, " +
                "\nthat they are endowed by their Creator with certain unalienable Rights,  " +
                "\nthat among these are Life,   Liberty and the Pursuit of Happiness. — " +
                "\nThat to secure these rights, Governments are instituted among Men, " +
                "\nderiving their just powers from the consent of the governed, — " +
                "\nThat whenever any Form of Government becomes destructive of these ends, " +
                "\nit is the Right of the People to alter or to abolish it, and to institute " +
                "\nnew Government, laying its foundation on such principles and organizing " +
                "\nits powers in such form, as to them shall seem most likely to effect their " +
                "\nSafety and Happiness.    Prudence, indeed, will dictate that Governments " +
                "\nlong established should not be changed for light and transient causes; " +
                "\nand accordingly all experience hath shewn that mankind are more disposed to suffer, " +
                "\nwhile evils are sufferable than to right themselves by abolishing the forms to which " +
                "\nthey are accustomed.   But when a long train of abuses and usurpations, " +
                "\npursuing invariably the same Object evinces a design to reduce them " +
                "\nunder absolute Despotism,   it is their right,  it is their duty, " +
                "\nto throw off such Government, and to provide new Guards for their future security.\"";
            Console.WriteLine(passage);
            Console.WriteLine("\nLet\'s remove all compound spaces:");
            Console.ReadLine();
            Console.WriteLine(Regex.Replace(passage, @"[ ]{2,}", " "));
            Console.WriteLine("\nInstances found: " + Regex.Matches(passage, @"[ ]{2,}").Count);
            var newPassage = 
            Console.ReadLine();
        }
    }
}
