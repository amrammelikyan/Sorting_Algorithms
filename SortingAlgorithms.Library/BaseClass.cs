using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SortingAlgorithms.Library
{
    public abstract class BaseClass
    {
        public abstract string Name { get; }

        public abstract void Sort(int[] array);

        public void SortAndPrint(int[] array)
        {
            Console.WriteLine();
            Console.WriteLine(Name);
            Stopwatch timer = new Stopwatch();
            timer.Start();
            Sort(array);
            timer.Stop();
            TimeSpan timeTaken = timer.Elapsed;
            long memory = GC.GetTotalMemory(true);
            Console.WriteLine("Running time: " + timeTaken.Minutes + ":" + timeTaken.Seconds + ":" + timeTaken.Milliseconds + ":" + timeTaken.Ticks);
            Console.WriteLine("Memory usage: " + memory);
        }
    }
}
