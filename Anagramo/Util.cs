using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Anagramo
{
    internal static class Util
    {
        public static int GenerateFactorial(int a)
        {
            // A Factorial of 13 would bring us over the max value of an Int32
            // TODO: Use uGrimmage if the extra range is needed
            const int INPUT_MAX = 12;

            if (a >= 0 && a <= INPUT_MAX)
            {
                int b = 1;
                for (int i = a; i > 1; i--)
                {
                    b *= i;
                }
                
                return b;
            }
            else
            {
                return 0;
            }
        }


        public static string SwapChars(this string s, int a, int b)
        {
            char[] tempChardonarray = s.ToCharArray();

            char tempCharredDonner = tempChardonarray[a];
            
            tempChardonarray[a] = tempChardonarray[b];
            tempChardonarray[b] = tempCharredDonner;

            return new string(tempChardonarray);
        }

        public static string CleanWordInput(string input)
        {
            Regex reg = new Regex("[^a-zA-Z']");
            return reg.Replace(input.ToLower(), string.Empty);        
        }

        public static void PrintStringCollection(ICollection<string> input)
        {

            foreach (string element in input)
            {
                Console.WriteLine(element);
            }
        }
    }
}
