namespace SomeAlgos.Check_if_number_is_prime
{
    public class PrimeNumber
    {
        public bool Check(int number) 
        {
            // check if the number is less than or equal to 1, as prime numbers are greater than 1
            if (number <= 1)
            {
                return false;
            }

            // check if the number is 2, as 2 is the only even prime number
            if (number == 2)
            {
                return true;
            }

            // check if the number is even, as all even numbers greater than 2 are not prime
            if (number % 2 == 0) 
            {
                return false;
            }

            // check for odd factors from 3 to the square root of the number
            int limit = (int)Math.Sqrt(number);

            // we can skip even numbers, so we start from 3 and increment by 2
            // even numbers > 2 are never prime → so after checking 2, ignore all even numbers.
            // only odd divisors can possibly divide an odd number → so start at 3 and jump by 2 (3, 5, 7, 9, …).
            // this makes your code about twice as fast as checking every number, and combined with the square root trick,
            // it's thousands of times faster than checking everything.
            for (int i = 3; i <= limit; i += 2)
            {
                if (number % i == 0)
                { 
                    return false;
                }
            }

            return true;
        }
    }
}
