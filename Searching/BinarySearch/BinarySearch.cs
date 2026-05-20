namespace SomeAlgos.Searching.BinarySearch
{
    public class BinarySearch
    {
        public int PerformBinarySearch(int[] array, int numberToFind)
        {
            int first = 0;
            int last = array.Length - 1;

            while (first <= last) 
            {
                int middle = first + (first + last) / 2;

                if (array[middle] == numberToFind)
                {
                    return middle;
                }
                else if( numberToFind < array[middle] )
                {
                    last = middle -1;
                }
                else
                {
                    first = middle + 1;
                }
            }

            return -1;
        }
    }
}
