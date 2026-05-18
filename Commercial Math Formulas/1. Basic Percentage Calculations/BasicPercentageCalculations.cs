
namespace CommercialMathFormulas._1._Basic_Percentage_Calculations
{
    public class BasicPercentageCalculations
    {
        /// <summary>
        /// Calculates what percentage one number is of another.
        /// </summary>
        public static decimal CalculatePercentage(decimal part, decimal whole)
        {
            if (whole == 0)
            {
                throw new DivideByZeroException("Whole cannot be zero.");
            } 
            
            return (part / whole) * 100;
        }


        /// <summary>
        /// Returns the given percentage of a number.
        /// </summary>
        public static decimal PercentageOf(decimal percentage, decimal number)
        {
            return (percentage / 100) * number;
        }


        /// <summary>
        /// Calculates the percentage change from old value to new value.
        /// </summary>
        public static decimal PercentageChange(decimal oldValue, decimal newValue)
        {
            if (oldValue == 0) 
            {
                throw new DivideByZeroException("Old value cannot be zero.");
            }
            
            return ((newValue - oldValue) / oldValue) * 100;
        }
    }
}
