
namespace CommercialMathFormulas._2._Discount_Calculations
{
    public class DiscountCalculations
    {
        // Calculates the discount amount based on a percentage. 
        public static decimal CalculateDiscountAmount(decimal originalPrice, decimal discountPercent)
        {
            return originalPrice * (discountPercent / 100);
        }

        
        // Applies a percentage discount to the original price.
        public static decimal ApplyDiscount(decimal originalPrice, decimal discountPercent)
        {
            return originalPrice - CalculateDiscountAmount(originalPrice, discountPercent);
        }

        
        // Calculates the effective discount percentage given a sale price.
        public static decimal CalculateDiscountPercentage(decimal originalPrice, decimal salePrice)
        {
            if (originalPrice == 0)
            {
                throw new DivideByZeroException();
            } 
            
            return ((originalPrice - salePrice) / originalPrice) * 100;
        }
    }
}
