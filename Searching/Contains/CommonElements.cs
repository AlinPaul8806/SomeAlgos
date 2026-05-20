namespace SomeAlgos.Searching.Contains
{
    public class CommonElements
    {
        public int CountCommonElements(string[] array1, string[] array2)
        {
            int counter = 0;
            var contains = new Contains();
            for (int i = 0; i < array1.Length; i++) 
            {
                if (contains.ContainsKey(array2, array1[i]))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
