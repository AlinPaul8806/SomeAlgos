
namespace SomeAlgos.Reverse_string
{
    public class ReverseString
    {
        public void ReverseStringExample(string input) 
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine($"Input string is null or empty.");
            }
            else 
            {
                char[] charArr = input.ToCharArray();
                char[] reversedArr = new char[charArr.Length];
                for ( int i = 0; i < charArr.Length; i++)
                {
                    reversedArr[i] = charArr[charArr.Length - 1 - i];
                }

                Console.WriteLine($"Your reversed string is: {new string(reversedArr)}.");
            }
        }
    }
}
