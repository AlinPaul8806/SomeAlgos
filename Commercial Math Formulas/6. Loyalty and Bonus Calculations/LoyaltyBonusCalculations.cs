using CommercialMathFormulas.Constants;

namespace CommercialMathFormulas.LoyaltyBonusCalculations
{
    public class LoyaltyBonusCalculations
    {
        // Points earned based on purchase amount.
        public static int CalculatePointsEarned(decimal purchaseAmount)
        {
            return (int)(purchaseAmount * EcommerceConstants.POINTS_PER_DOLLAR);
        }


        // Converts points to a monetary value (e.g., 100 points = $1).
        public static decimal RedeemPoints(int points, decimal pointsToDollarRate = 0.01m)
        {
            return points * pointsToDollarRate;
        }


        // Calculates a bonus amount (e.g., sign-up bonus, referral).
        public static decimal CalculateBonus(decimal baseAmount, decimal bonusPercent)
        {
            return baseAmount * (bonusPercent / 100);
        }
    }
}