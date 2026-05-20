namespace SomeAlgos.Find_Min_and_Max
{
    public class FindMinMax
    {
        public void FindMax(int[] numbers) 
        {
            int max = 0;
            if (numbers == null)
            {
                Console.WriteLine($"The array is null.");
            }
            else 
            {
                for (int i = 0; i < numbers.Length; i++) 
                {
                    if (numbers[i] > max)
                    { 
                        max = numbers[i];
                    }
                }
            }

            Console.WriteLine($"Max is: {max}.");
        }

        public void FindMin(int[] numbers) 
        {
            int min = 0;
            if (numbers == null)
            {
                Console.WriteLine($"The array is null.");
            }
            else
            {
                min = numbers[0];
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] < min)
                    {
                        min = numbers[i];
                    }
                }
            }

            Console.WriteLine($"Min is: {min}.");
        }

    }
}
