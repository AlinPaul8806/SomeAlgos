namespace SomeAlgos.Fibonacci
{
    public class Fibonacci
    {
        public long ComputeFibonacci(int n)
        {
            int first = 0;
            int second = 1;
            

            for (int i = 0; i < n; i++)
            { 
                int temp = first;
                first = temp + second;
                second = temp;
            }
            return first;
        }
    }
}
