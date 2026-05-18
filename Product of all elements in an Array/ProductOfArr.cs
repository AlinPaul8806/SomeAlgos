

namespace SomeAlgos.Factorial
{
    internal class ProductOfArr
    {
        public static int ProductOfArrCalc(int[] arr) 
        {
            int fact = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                fact = fact * arr[i];
            }
            return fact;
        }
    }
}
