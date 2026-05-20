using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SomeAlgos.Merge_two_sorted_arrays
{
    public class MergeSortedArrays
    {
        public int[] Merge(int[] array1, int[] array2)
        {
            var result = new List<int>();

            int i = 0, j = 0;
            while (i < array1.Length && j < array2.Length)
            {
                if (array1[i] < array2[j])
                {
                    result.Add(array1[i++]); //array1[i++] takes the element at the current index i, and then automatically moves i to the next position for the next loop iteration.
                }
                else 
                {
                    result.Add(array2[j++]); //array2[j++] takes the element at the current index j, and then automatically moves j to the next position for the next loop iteration.
                }
            }

            // After one array is exhausted (all its elements taken), the other array may still have remaining elements.
            // Because both arrays were sorted, those leftovers are already larger than everything in the result, so we can just tack them on at the end.

            result.AddRange(array1.Skip(i));
            result.AddRange(array2.Skip(j));

            return result.ToArray();
        }
    }
}
