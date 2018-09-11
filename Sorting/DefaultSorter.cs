using System;

namespace Sorting
{
    public class DefaultSorter:ISorter
    {
        public int[] Sort(int[] arrayToSort)
        {
            Array.Sort(arrayToSort);
            return arrayToSort;
        }
    }
}
