using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SomeAlgos.Count_Unique_Elements_In_A_List
{
    public class CountUniqueElemList
    {
        /// <summary>
        /// A HashSet<T> automatically stores only unique elements – When you pass a collection (like a List<T>) 
        /// to the HashSet<T> constructor, it iterates through each element and adds it to the set. 
        /// If an element already exists in the set, it’s ignored. This eliminates duplicates.
        /// The Count property of the HashSet<T> returns the number of distinct elements after deduplication.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns>The number of unique elements in the list.</returns>


        public static int CountUnique<T>(List<T> items)
        {
            if (items == null) return 0;
            var uniqueItems = new HashSet<T>(items);
            return uniqueItems.Count;
        }
    }
}
