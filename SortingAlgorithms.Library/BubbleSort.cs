using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Library
{
    public class BubbleSort : BaseClass
    {
        public override string Name { get => "Bubble Sort"; }

        public override void Sort(int[] array)
        {
            int lenght = array.Length - 1;

            while (lenght > 1)
            {
                for (int j = 0; j < lenght; j++)
                {
                    if (array[j + 1] < array[j])
                    {
                        array[j + 1] += array[j];
                        array[j] = array[j + 1] - array[j];
                        array[j + 1] -= array[j];
                    }
                }
                lenght--;
            }
        }
    }
}
