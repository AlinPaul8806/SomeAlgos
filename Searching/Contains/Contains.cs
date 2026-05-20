
namespace SomeAlgos.Searching.Contains
{
    public class Contains
    {
        public bool ContainsKey(string[] array, string key)
        {
            foreach (var item in array) 
            {
                if (item == key)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
