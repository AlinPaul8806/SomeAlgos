namespace SomeAlgos.Sum_of_numbers_in_array
{
    public class SumOfNumbersInArray
    {
        public static int SumInArr(int[] array) 
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++) 
            {
                sum = sum + array[i];
            } 
            return sum;
        }
    }
}
