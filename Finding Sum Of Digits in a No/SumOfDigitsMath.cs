namespace SomeAlgos.Finding_Sum_Of_Digits_in_a_No
{
    public class SumOfDigitsMath
    {
        public void SumOfDigitsMathFunc(int number) 
        {
            int sum = 0;

            // We use a temporary variable so we don't destroy the original number
            int currentNumber = number;

            while (currentNumber > 0)
            {
                // 1. Get the remainder when dividing by 10 (the last digit)
                int lastDigit = currentNumber % 10;

                // 2. Add that digit to our total sum
                sum = sum + lastDigit;

                // 3. Divide by 10 to "chop off" the last digit 
                // (Since it's an integer, it drops the decimal)
                currentNumber = currentNumber / 10;
            }

            Console.WriteLine("The sum of the digits is : " + sum);
        }   

    }
}
