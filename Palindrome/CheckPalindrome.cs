

using System.ComponentModel.Design;

namespace SomeAlgos.Palindrome
{
    public class CheckPalindrome
    {
        public static void CheckIfStrIsPalindrome(string str) 
        {
            string s = str.Trim().ToLower(); // Added ToLower so 'Abba' works
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                {
                    Console.WriteLine("The string is not a palindrome");
                    return; // Exit early if a mismatch is found
                }
                left++;
                right--;
            }

            Console.WriteLine("The string is a palindrome");
        }
    }
}
