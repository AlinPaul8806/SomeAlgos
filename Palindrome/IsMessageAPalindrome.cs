using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;

namespace SomeAlgos.Palindrome
{
    public class IsMessageAPalindrome
    {

        //Dennis and Edna sinned.
        //Murder for a jar of red rum.
        //Borrow or rob?
        //Are we not drawn onward, we few, drawn onward to new era?

        public static void CheckIfMessageIsPalindrome(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                return;
            } 

            int left = 0;
            int right = message.Length - 1;
            bool isPalindrome = true;

            while (left < right)
            {
                // Skip non-alphanumeric characters
                if (!char.IsLetterOrDigit(message[left]))
                {
                    left++;
                }
                else if (!char.IsLetterOrDigit(message[right]))
                {
                    right--;
                }
                else
                {
                    // Compare characters (case-insensitive)
                    if (char.ToLower(message[left]) != char.ToLower(message[right]))
                    {
                        isPalindrome = false;
                        break;
                    }
                    left++;
                    right--;
                }
            }

            Console.WriteLine(isPalindrome ? "The message is a palindrome." : "The message is not a palindrome.");
        }



    }
}
