using System;

namespace SortingAlgorithms.Library
{
    public class InsertionSort : BaseClass
    {
        public override string Name { get => "Insertion Sort"; }

        public override void Sort(int[] array)
        {
            int position = 0;
            int num;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {
                    num = array[i];
                    array[i] = array[i - 1];
                    for (int j = i - 2 ; j >= 0; j--)
                    {
                        if (array[j] > num)
                        {
                            array[j + 1] = array[j];
                            position = j;
                        }
                        else break;
                    }
                    array[position] = num;
                }
            }

        }
    }
}
