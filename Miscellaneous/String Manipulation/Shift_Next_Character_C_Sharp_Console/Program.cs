using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftEachCharacter
{
    //  Given a string S, shift each character to its immediate right character (note: preserve the cases) 
    //  Sample input : HeLlo
    //  Sample output : IfMmp
    class Program
    {
        static void Main(string[] args)
        {
            string result = string.Empty; 
            Console.WriteLine("Enter the string");
            string givenString = Console.ReadLine();
            if (givenString.Trim() == string.Empty)
            {
                Console.WriteLine("Enter Correct string, Exiting application...");
            }
            else
            {
                char[] charArray = givenString.ToCharArray();

                foreach (char singleChar in charArray)
                {
                    bool isCharUpper = char.IsUpper(singleChar);
                    char tempChar;

                    if (singleChar == 'Z' || singleChar == 'z')
                    {
                        tempChar = 'a';
                        if (isCharUpper) tempChar = 'A';
                    }
                    else
                    {
                        tempChar = (char)(singleChar + 1);
                    }

                    result += tempChar;
                }
                Console.WriteLine("The output is : " + result);
            }
            Console.ReadLine();            
        }
    }
}
