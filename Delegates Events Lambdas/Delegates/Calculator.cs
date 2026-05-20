
namespace DelegatesEventsLambdas.Delegates
{
    public class Calculator
    {
        public void DisplaySum(int a, int b)
        {
            Console.WriteLine($"The sum of {a} and {b} is: {a + b}");
        }

        public void DisplayDiference(int a, int b)
        {
            Console.WriteLine($"The difference between {a} and {b} is: {a - b}");
        }

        public void DisplayTwoTimesTotal(int a, int b)
        {
            Console.WriteLine($"Two times the total of {a} and {b} is: {(a + b) * 2}");
        }

        public string ReturnTotal(int a, int b)
        { 
            var result = a+ b;  
            return result.ToString();
        }

        public int MakeSquare(int x)
        {
            return x * x;
        }
    }
}
