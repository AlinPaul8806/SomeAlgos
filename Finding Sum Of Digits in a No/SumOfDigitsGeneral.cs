namespace SomeAlgos.Finding_Sum_Of_Digits_in_a_No
{
    public class SumOfDigitsGeneral
    {
        public static void SumOfDigitsGen(int number) 
        {
            string strNumber = number.ToString();
            char[] chars = strNumber.ToCharArray();

            int sum = 0;

            for (   int i = 0; i < chars.Length; i++)
            { 
                sum = sum + (chars[i] - '0'); // - the actual ASCII value of char '0' which is 48. '0' = 48 , '1' = 49 , '2' = 50 ... and so on
            }

            Console.WriteLine($"The sum of the digits is : {sum}");
        }
    }
}
