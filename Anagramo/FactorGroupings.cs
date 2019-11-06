using System.Collections.Generic;
using System;
using System.Linq;

namespace Anagramo
{
    class FactorGroupings
    {
        public static List<List<int>> Output;

        public FactorGroupings()
        {
            Output = new List<List<int>>();
        }

        public List<List<int>> GetFactorGroupings(List<int> wordFactors, int product)
        {
            List<int> emptyList = new List<int>();
            Console.Write("Finding factor groupings for ");
            Util.PrintIntList(wordFactors);
            FindAllFactorGroups(wordFactors,product,emptyList);
            return Output;
        }   

        public void PrintAllFactorGroupings()
        {
            if (Output.Any())
            {
                int hello = 0;
                foreach(List<int> element in Output)               
                {
                    hello++;
                    Console.WriteLine("Print iteration " + hello);
                    Util.PrintIntList(element);
                }
            }
            else
            {
                Console.WriteLine("No factors groupings were found :(");
            }
        }   



        public void FindAllFactorGroups(List<int> factors,int ultimateProduct,List<int> group)
        {

            int factorsCount = factors.Count;
            int currentProduct;

            // If the group is empty, use a current product of 1 to allow multiplication
            if (!group.Any())
            {
                currentProduct = 1;
            }
            // Else get the current product by multiplying the current group elements together
            else
            {
                currentProduct = Util.MultiplyIntListTogether(group);
            }

            // If the current product is the ultimate product, add the current group to the output
            if (currentProduct == ultimateProduct)
            {
                if (!Output.Contains(group))
                {
                    Output.Add(group);
                }            
            }

            // If the current product is over the goal total
            if (currentProduct >= ultimateProduct)
            {
                return;
            }

            for (int i = 0; i < factorsCount; i++)
            {
                int possibleFactor =  factors[i];
                List<int> newGroup = new List<int>(group);
                newGroup.Add(possibleFactor);
                List<int> remainingFactors = factors.GetRange(i+1,factorsCount-i-1);
                // Start a recursion with the new group
                FindAllFactorGroups(remainingFactors,ultimateProduct,newGroup);

            }
        }
        
    }
}

