using CommercialMathFormulas.Constants;

namespace CommercialMathFormulas.TaxCalculations
{
    public class TaxCalculations
    {
        // Calculates tax amount for a given subtotal using the US tax rate.
        public decimal CalculateTax(decimal subtotal)
        {
            return subtotal * EcommerceConstants.TAX_RATE_US;
        }


        // Adds tax to a subtotal.
        public decimal AddTax(decimal subtotal)
        {
            return subtotal + CalculateTax(subtotal);
        }


        // Extracts the tax amount from a total that already includes tax.
        public decimal TaxFromTotal(decimal totalIncludingTax)
        {
            return totalIncludingTax - (totalIncludingTax / (1 + EcommerceConstants.TAX_RATE_US));
        }
    }
}
