using System;
using System.Linq;

namespace CommercialMathFormulas.AdvancedPricingFormulas
{
    public class AdvancedPricingFormulas
    {
        // Volume discount: price per unit decreases as quantity increases.
        public decimal VolumeDiscount(decimal basePrice, int quantity, (int minQty, decimal discountPercent)[] tiers)
        {
            var applicableTier = tiers.OrderBy(t => t.minQty).LastOrDefault(t => quantity >= t.minQty);
            if (applicableTier == default)
            {
                return basePrice * quantity;
            } 

            decimal discountedUnitPrice = basePrice * (1 - applicableTier.discountPercent / 100);
            
            return discountedUnitPrice * quantity;
        }


        // Bundle pricing: discount when items are bought together.
        public decimal BundlePrice(decimal[] individualPrices, decimal bundleDiscountPercent)
        {
            decimal totalIndividual = individualPrices.Sum();
            
            return totalIndividual * (1 - bundleDiscountPercent / 100);
        }


        // Price skimming: initial high price, then gradual reductions (returns price after N days).
        public decimal SkimmingPrice(decimal initialPrice, decimal reductionRatePerDay, int days)
        {
            return initialPrice * (decimal)Math.Pow((double)(1 - reductionRatePerDay / 100), days);
        }
    }
}