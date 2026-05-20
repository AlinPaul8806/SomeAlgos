using System;
using System.Collections.Generic;

namespace CommercialMathFormulas.FraudDetectionFormulas
{
    public class FraudDetectionFormulas
    {
        // Velocity check: number of orders in a time window exceeds threshold.
        public bool ExceedsVelocity(int orderCount, int timeWindowMinutes, int maxOrdersPerWindow)
        {
            // timeWindowMinutes is the period considered; we assume we have the count.
            return orderCount > maxOrdersPerWindow;
        }


        // Address mismatch score: returns a risk score between 0 and 100.
        public decimal AddressMismatchScore(string billingCountry, string shippingCountry, string ipCountry)
        {
            decimal score = 0;
            if (billingCountry != shippingCountry)
            {
                score += 40;
            }

            if (billingCountry != ipCountry)
            {
                score += 30;
            }

            if (shippingCountry != ipCountry)
            {
                score += 30;
            } 
            
            return Math.Min(score, 100);
        }


        // Checks if the order amount is unusually high compared to historical average.
        public bool UnusuallyHighAmount(decimal orderAmount, decimal historicalAvg, decimal stdDev, decimal zScoreThreshold = 3)
        {
            // Z-score = (orderAmount - avg) / stdDev
            if (stdDev == 0) 
            {
                return false;
            }
            
            decimal zScore = (orderAmount - historicalAvg) / stdDev;
            
            return Math.Abs(zScore) > zScoreThreshold;
        }
    }
}