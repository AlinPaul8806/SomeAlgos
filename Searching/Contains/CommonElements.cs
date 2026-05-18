namespace SomeAlgos.Searching.Contains
{
    public class CommonElements
    {
        public static int CountCommonElements(string[] array1, string[] array2)
        {
            int counter = 0;
            for (int i = 0; i < array1.Length; i++) 
            {
                if (Contains.ContainsKey(array2, array1[i]))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
