using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

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
            Regex reg = new Regex("[^a-zA-Z]");
            return reg.Replace(input.ToLower(), string.Empty);        
        }

        public static void PrintStringList(List<string> input)
        {

            foreach (string element in input)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();
        }

        public static void PrintListOfStringLists(List<List<string>> input)
        {

            foreach (List<string> element in input)
            {
                PrintStringList(element);
            }
        }

        public static void PrintIntList(List<int> input)
        {
            Console.Write("{ ");

            foreach (int element in input)
            {
                if (!(element == input[0])) 
                { Console.Write(", ");}

                Console.Write(element);
            }

            Console.Write(" }\n");
        }

        public static int MultiplyIntListTogether(List<int> input)
        {
            int output = 1;
            
            foreach (int element in input)
            {
                output *= element;
            }

            return output;
        }

        public static List<int> Factors(this int me)
        {
            Console.WriteLine("Finding factors for " + me);
            return Enumerable.Range(1, me).Where(x => me % x == 0).ToList();
            
        }
    }
}
