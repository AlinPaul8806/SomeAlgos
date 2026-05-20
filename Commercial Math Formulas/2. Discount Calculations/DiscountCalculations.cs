
namespace CommercialMathFormulas._2._Discount_Calculations
{
    public class DiscountCalculations
    {
        // Calculates the discount amount based on a percentage. 
        public decimal CalculateDiscountAmount(decimal originalPrice, decimal discountPercent)
        {
            return originalPrice * (discountPercent / 100);
        }

        
        // Applies a percentage discount to the original price.
        public decimal ApplyDiscount(decimal originalPrice, decimal discountPercent)
        {
            return originalPrice - CalculateDiscountAmount(originalPrice, discountPercent);
        }

        
        // Calculates the effective discount percentage given a sale price.
        public decimal CalculateDiscountPercentage(decimal originalPrice, decimal salePrice)
        {
            if (originalPrice == 0)
            {
                throw new DivideByZeroException();
            } 
            
            return ((originalPrice - salePrice) / originalPrice) * 100;
        }
    }
}
