namespace DelegatesEventsLambdas.Delegates
{
    public class TaxCalculator
    {
        public double CalculateTax(int taxPercentage, int amount)
        {
            return (taxPercentage / 100.0) * amount;
        }
    }
}
