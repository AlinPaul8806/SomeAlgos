
namespace SomeAlgos.Finding_Sum_Of_Digits_in_a_No
{
    public class SumOfDigits
    {
        public void SumOfFourDigits(int number) 
        {
            int firstDigit = (int)(number / 1000);
            int remainingDigit = number % 1000;
            int secondDigit = (int)(remainingDigit / 100);
            int thirdDigit = (int)((remainingDigit % 100) / 10);
            
            remainingDigit = (int)(remainingDigit % 100);

            int fourthDigit = remainingDigit % 10;

            Console.WriteLine($"First digit: {firstDigit}");
            Console.WriteLine($"Second digit: {secondDigit}");
            Console.WriteLine($"Third digit: {thirdDigit}");
            Console.WriteLine($"Fourth digit: {fourthDigit}");

            Console.WriteLine($"The sum of the digits is {firstDigit + secondDigit + thirdDigit + fourthDigit}");
        }
    }
}
