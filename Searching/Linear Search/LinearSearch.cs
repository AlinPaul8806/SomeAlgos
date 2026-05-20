
namespace SomeAlgos.Searching.Linear_Search
{
    /// <summary>
    /// Linear searching returns the first element that applies the condition. 
    /// The longer the collection, the more steps it needs to succeed. 
    /// Works even if the collection is not ordered.
    /// </summary>
    public class LinearSearch
    {
        public void Search(int[] arr, int itemToSearch)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == itemToSearch)
                {
                    Console.WriteLine($"Item found at index {i}");
                    return;
                }
            }
            Console.WriteLine("Item not found");
        }

        //properly done:
        public int SearchInt(int[] arr, int itemToSearch)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == itemToSearch) 
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
