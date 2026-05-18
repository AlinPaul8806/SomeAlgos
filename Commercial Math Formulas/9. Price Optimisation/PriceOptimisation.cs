using System;

namespace CommercialMathFormulas.PriceOptimisation
{
    public class PriceOptimisation
    {
        // Simple linear price elasticity: new price = old price * (1 - (demandChange%/priceChange%)).
        public static decimal ElasticityBasedPrice(decimal currentPrice, decimal demandChangePercent, decimal elasticity)
        {
            // ΔP/P = (ΔD/D) / elasticity
            decimal priceChangePercent = demandChangePercent / elasticity;
            
            return currentPrice * (1 + priceChangePercent / 100);
        }


        // Calculates the price that maximizes revenue given a demand curve (linear example).
        public static decimal RevenueMaximizingPrice(decimal maxPrice, decimal minPrice, decimal demandAtMin, decimal demandAtMax)
        {
            // Assume linear demand: Q = a - b*P
            // Revenue = P * (a - bP) => derivative => a - 2bP = 0 => P = a/(2b)
            // We can compute a and b from two points.
            if (maxPrice == minPrice)
            {
                return minPrice;
            } 
            
            decimal b = (demandAtMin - demandAtMax) / (maxPrice - minPrice);
            decimal a = demandAtMin + b * minPrice;
            
            if (b <= 0) 
            {
                throw new InvalidOperationException("Demand must be decreasing with price.");
            }
            
            return a / (2 * b);
        }

        // Dynamic pricing based on competitor's price (simple rule).
        public static decimal MatchCompetitorPrice(decimal competitorPrice, decimal undercutPercent = 0)
        {
            return competitorPrice * (1 - undercutPercent / 100);
        }
    }
}