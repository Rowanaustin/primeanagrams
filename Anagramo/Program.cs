using System;
using System.Runtime.CompilerServices;

//This line means that all of our "internal" classes are exposed to our Test project
//Notice that the Calculator class is internal - see what happens if you comment this line and try to build the solution
[assembly:InternalsVisibleTo("Anagramo.Tests")]
namespace Anagramo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word");

            while (true)
            {
                var permuteString = Console.ReadLine();
                if (permuteString != null)
                {
                    Permuter.GetPermutations(permuteString.ToCharArray());
                }
            }
        }
    }
}