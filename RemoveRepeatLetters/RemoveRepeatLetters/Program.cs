using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveRepeatLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given a string, remove any repeated letters.

            //String
            string s = "Hello World";
            s = "What happens to all the spaces?";

            //Character array to keep track of all unique characters
            char[] str = new char[s.Length];

            //Boolean swich for whether current letter has occurred so far
            bool exist=false;

            //Int to track the position of last letter added to character array str
            int position = 0;

            //Check each letter in original string s
            for(int i = 0; i<s.Length; i++)
            {
                //Check str if s[i] exists so far.  str has length position
                for(int j = 0; j < position; j++)
                {
                    if (s[i] == '\x0020') break; //ignore all spaces (optional)
                    if (str[j] == '\0') break; //stop iterating if a null char has been encountered
                    if (str[j] == s[i]) exist = true; //flag exist if s[i] exists in str
                    
                }

                //If exist is false then s[i] is unique and should be added to str
                if (exist == false)
                {
                    str[position] = s[i];
                    position++; //increment size of str
                }

                exist = false; //in case exist is true, reset to false for next iteration
                
            };

            //Convert char array str to string newStr
            string newStr = new string(str);

            Console.WriteLine(newStr);
            Console.ReadLine();
        }

    }
}
