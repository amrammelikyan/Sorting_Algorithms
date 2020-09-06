using System;
using SortingAlgorithms.Library;

namespace SortingAlgorithms.App
{
    delegate void Sortings(int[] array);
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Execute();
            }
        }
        static void Execute()
        {
            BaseClass insertion = new InsertionSort();
            BaseClass bubble = new BubbleSort();
            BaseClass merge = new MergeSort();
            Random rand = new Random();
            int arrayLebght;
            int[] array;
            string option;

            Console.Write("\nPlease enter the size of an array that you want to sort: ");
            arrayLebght = Convert.ToInt32(Console.ReadLine());

            array = new int[arrayLebght];
            for (int i = 0; i < arrayLebght; i++)
            {
                array[i] = rand.Next(1, arrayLebght * 5);
            }
            Console.WriteLine("\n1.Insertion sort \n2.Bubble sort \n3.Quick sort \n4.All\n");
            Console.Write("Select which algorithm you want to perform: ");

            option = Console.ReadLine();

            Sortings[] sortings = { insertion.SortAndPrint, bubble.SortAndPrint, merge.SortAndPrint };

            if (option.Length == 1 && Convert.ToInt32(option) < sortings.Length + 1)
            {
                sortings[Convert.ToInt32(option) - 1](array);
            }
            else if (option.Length == 3)
            {
                int first = Convert.ToInt32(option[0].ToString()) - 1;
                int last = Convert.ToInt32(option[2].ToString()) - 1;

                sortings[first](array);
                if (option.Contains('-'))
                {
                    for (int i = first + 1; i < last; i++)
                    {
                        sortings[i](array);
                    }
                }
                sortings[last](array);
            }
            else if (Convert.ToInt32(option) == sortings.Length + 1)
            {
                for (int i = 0; i < sortings.Length; i++)
                {
                    sortings[i](array);
                }
            }
        }
    }
}
