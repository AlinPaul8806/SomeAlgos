
namespace SomeAlgos.Counting
{
    public class Counting
    {
        public static int CountIfAbove(int[] array, int value) 
        {
            int counter = 0;
            foreach (var item in array)
            {
                if (item > value) 
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
