using System;
using System.Collections;
using System.Collections.Generic;

namespace Anagramo
{
    internal static class Permuter
    {
        public static IEnumerable<IEnumerable<T>> GetPermutations<T>(this IList<T> target)
        {
            ICollection<IList<T>> result = new List<IList<T>>();
            Generate(target, target.Count, result);
            return result;
        }

        /// <summary>
        /// Recursive Heap algorithm to generate permutations of an List
        /// </summary>
        /// <param name="perm">The current permutation : Initially the input for which the collection will be filled</param>
        /// <param name="k">Upper bounds for searching for elements to swap : Initially the length of the input</param>
        /// <param name="result">The Collection to be populated by permutations</param>
        /// <typeparam name="T"></typeparam>
        private static void Generate<T>(IList<T> perm, int k, ICollection<IList<T>> result)
        {
            // The perm is the current permuation we are operating on
            // The reason this must be an IList is because we need to be able to address individual elements by index for when we swap them
            
            // The result is a collection of our permutations
            // The reason the result needs to be ICollection is so that we can Add new permutations to it
            
            if (k == 1)
            {
                // Create a new concrete List using the contents of the current permutation, then add this to our results container
                var newPerm = new List<T>(perm);
                result.Add(newPerm);
                
                // COMMMENTED OUT - prints every permutation as it is calculated
                // PrintList(newPerm);
            }
            else
            {
                for (int i = 0; i < k; i++)
                {
                    Generate(perm, k-1, result);
                    
                    if (k % 2 == 0)
                    {
                        // If the length of our current subset is even, swap the ith element
                        perm.SwapElements(i, k-1);
                    }
                    else
                    {
                        // Otherwise, always swap the 0th element
                        perm.SwapElements(0, k-1);
                    }
                }
            }
        }
        
        /// <summary>
        /// Print comma-separated elements of a List 
        /// </summary>
        private static void PrintList<T>(IList<T> list)
        {
            string output = "";
            foreach (var e in list)
            {
                output += e.ToString() + ", ";
            }
            Console.WriteLine(output);
        }

        /// <summary>
        /// Extension method to swap two elements of the list
        /// </summary>
        /// <param name="i">index of first element</param>
        /// <param name="j">index of second element</param>
        private static void SwapElements<T>(this IList<T> target, int i, int j)
        {
            var temp = target[i];
            target[i] = target[j];
            target[j] = temp;
        }
    }
}