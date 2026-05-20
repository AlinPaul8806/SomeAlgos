using CommercialMathFormulas.Constants;

namespace CommercialMathFormulas.ShippingCalculations
{
    public class ShippingCalculations
    {
        // Determines if an order qualifies for free shipping.
        public bool IsFreeShippingEligible(decimal orderTotal)
        {
            return orderTotal >= EcommerceConstants.FREE_SHIPPING_THRESHOLD;
        }

        // Calculates shipping cost based on weight and zone (simple example).
        public decimal CalculateShippingCost(decimal weight, string zone)
        {
            // Simplified logic: $5 base + $2 per lb for zone A, $3 per lb for zone B
            return zone.ToUpper() switch
            {
                "A" => 5.00m + (weight * 2.00m),
                "B" => 5.00m + (weight * 3.00m),
                _ => 10.00m // default
            };
        }

        // Applies free shipping if threshold is met, otherwise returns standard cost.
        public decimal ApplyFreeShippingThreshold(decimal orderTotal, decimal standardShippingCost)
        {
            return IsFreeShippingEligible(orderTotal) ? 0 : standardShippingCost;
        }
    }
}