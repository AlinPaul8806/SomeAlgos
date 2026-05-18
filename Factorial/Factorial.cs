using System.Numerics;

namespace SomeAlgos.Factorial
{
    public class Factorial
    {
        public static BigInteger ComputeFactorial(int n) 
        {
            ArgumentOutOfRangeException.ThrowIfNegative(n);

            BigInteger result = 1;

            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }

            return result;
        }
    }
}
