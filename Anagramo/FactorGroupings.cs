using System.Collections.Generic;
using System;
using System.Linq;

namespace Anagramo
{
    class FactorGroupings
    {
        public static List<List<ulong>> Output;

        public FactorGroupings()
        {
            Output = new List<List<ulong>>();
        }

        public List<List<ulong>> GetFactorGroupings(List<ulong> wordFactors, ulong product)
        {
            List<ulong> emptyList = new List<ulong>();
            Console.Write("Finding factor groupings for ");
            Util.PrintULongList(wordFactors);
            FindAllFactorGroups(wordFactors,product,emptyList);
            return Output;
        }   

        public void PrintAllFactorGroupings()
        {
            if (Output.Any())
            {
                ulong hello = 0;
                foreach(List<ulong> element in Output)               
                {
                    hello++;
                    Console.WriteLine("Print iteration " + hello);
                    Util.PrintULongList(element);
                }
            }
            else
            {
                Console.WriteLine("No factors groupings were found :(");
            }
        }   



        public void FindAllFactorGroups(List<ulong> factors,ulong ultimateProduct,List<ulong> group)
        {
            Console.Write("Building possible group... ");
            if (group.Any())
            {
                Util.PrintULongList(group);
            }

            int factorsCount = factors.Count;
            ulong currentProduct;

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
                ulong possibleFactor =  factors[i];
                List<ulong> newGroup = new List<ulong>(group);
                newGroup.Add(possibleFactor);
                List<ulong> remainingFactors = factors.GetRange(i+1,factorsCount-i-1);
                // Start a recursion with the new group
                FindAllFactorGroups(remainingFactors,ultimateProduct,newGroup);

            }
        }
        
    }
}

