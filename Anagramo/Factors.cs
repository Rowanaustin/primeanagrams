using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public static class Factors
{
    public static List<ulong> GetFactors(ulong number)
    {
        Console.WriteLine($"finding factors of {number}");

        const int NUM_TASKS = 8;

        // Array will hold our tasks
        var tasks = new Task<List<ulong>>[NUM_TASKS];

        // list for final output
        List<ulong> output = new List<ulong>();
        
        // how many numbers each task will do
        ulong split = (ulong)Math.Floor((double)number / NUM_TASKS);

        // the remainder of the split - the last task will have this many extra to do
        ulong remainder = number % NUM_TASKS;

        for (ulong i=0; i < NUM_TASKS; i++)
        {
            // start point - we never start from zero or else dividebyzeroexception
            ulong start = 1 + (i*split);

            // end - end is inclusive so minus 1
            ulong end = start + split-1;

            //The last one also does the remainder
            if (i == NUM_TASKS-1)
            {
                tasks[i] = Task.Run<List<ulong>>( () => GetFactorsInRange(number,start, end+remainder));
            }
            else
            {
                tasks[i] = Task.Run<List<ulong>>( () => GetFactorsInRange(number,start,end));
            }
        }

        //Wait for our tasks - this is the heavy lifting
        Task.WaitAll(tasks);

        // Combine our results into one list
        foreach (var t in tasks)
        {   
            output.AddRange(t.Result);
        }
        
        return output;
    }

    public static List<ulong> GetFactorsInRange(ulong number, ulong start, ulong end)
    {
        var output = new List<ulong>();

        Console.WriteLine($"start={start}, end={end}");

        for (ulong i=start; i <= end; i++)
        {
            if (number % i == 0)
            {
                output.Add(i);
            }
        }
        
        return output;
    }
}