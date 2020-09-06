using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SortingAlgorithms.Library
{
    public class MergeSort : BaseClass
    {
        public override string Name { get => "Merge Sort";}
        public override void Sort(int[] array)
        {
            int l = 0;
            int r = array.Length - 1;
            Sort(array, l, r);
        }
        private void Sort(int[] array, int l, int r)
        {
            int mid = (l + r) / 2;
            if (r - l > 1)
            {
                Sort(array, l, mid);
                Sort(array, mid + 1, r);
            }
            var list = new List<int>();

            for (int i = l, j = mid + 1; i <= mid || j <= r;)
            {
                 if (i <= mid && (j > r || array[i] <= array[j]))
                {
                    list.Add(array[i]);
                    i++;
                }
                else if (j <= r && (i > mid || array[i] > array[j]))
                {
                    list.Add(array[j]);
                    j++;
                }
            }

            for (int i = l; i <= r; i++)
            {
                array[i] = list[i - l];
            }
        }
    }
}
