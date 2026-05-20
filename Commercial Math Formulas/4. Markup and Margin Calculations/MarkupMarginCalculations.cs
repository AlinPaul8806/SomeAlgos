namespace CommercialMathFormulas.MarkupMarginCalculations
{
    public class MarkupMarginCalculations
    {
        // Calculates selling price based on cost and markup percentage (markup on cost).
        public decimal SellingPriceFromMarkup(decimal cost, decimal markupPercent)
        {
            return cost * (1 + markupPercent / 100);
        }


        // Calculates the margin percentage (profit / selling price).
        public decimal MarginPercentage(decimal cost, decimal sellingPrice)
        {
            if (sellingPrice == 0) throw new DivideByZeroException();
            return ((sellingPrice - cost) / sellingPrice) * 100;
        }


        // Converts a markup percentage to a margin percentage.
        public decimal MarkupToMargin(decimal markupPercent)
        {
            return (markupPercent / (100 + markupPercent)) * 100;
        }


        //Converts a margin percentage to a markup percentage.
        public decimal MarginToMarkup(decimal marginPercent)
        {
            if (marginPercent >= 100) throw new ArgumentException("Margin cannot be 100% or more.");
            return (marginPercent / (100 - marginPercent)) * 100;
        }
    }
}