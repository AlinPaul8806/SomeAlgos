using CommercialMathFormulas.Constants;

namespace CommercialMathFormulas.CommissionCalculations
{
    public class CommissionCalculations
    {
        // Simple commission based on a fixed percentage.
        public decimal CalculateCommission(decimal saleAmount, decimal commissionRate)
        {
            return saleAmount * (commissionRate / 100);
        }


        // Tiered commission: different rates for different portions.
        public decimal TieredCommission(decimal saleAmount, (decimal threshold, decimal rate)[] tiers)
        {
            decimal commission = 0;
            decimal remaining = saleAmount;

            foreach (var tier in tiers)
            {
                if (remaining <= 0) break;
                decimal applicable = Math.Min(remaining, tier.threshold);
                commission += applicable * (tier.rate / 100);
                remaining -= applicable;
            }
            return commission;
        }


        // Calculates the credit card processing fee using the constant.
        public decimal CreditCardFee(decimal amount)
        {
            return amount * EcommerceConstants.CREDIT_CARD_FEE;
        }


        // Calculates the PayPal fee using the constant.
        public decimal PayPalFee(decimal amount)
        {
            return amount * EcommerceConstants.PAYPAL_FEE;
        }
    }
}