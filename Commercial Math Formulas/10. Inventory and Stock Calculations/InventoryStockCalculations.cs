using System;

namespace CommercialMathFormulas.InventoryStockCalculations
{
    public class InventoryStockCalculations
    {
        // Calculates reorder point: (avg daily usage * lead time in days) + safety stock.
        public decimal ReorderPoint(decimal avgDailyUsage, int leadTimeDays, decimal safetyStock)
        {
            return (avgDailyUsage * leadTimeDays) + safetyStock;
        }

        // Safety stock based on demand variability and service level (simplified).
        public decimal SafetyStock(decimal stdDevDailyDemand, int leadTimeDays, decimal serviceFactor)
        {
            // Using basic formula: safety stock = Z * σ * √(lead time)
            return serviceFactor * stdDevDailyDemand * (decimal)Math.Sqrt(leadTimeDays);
        }

        // Inventory turnover = cost of goods sold / average inventory.
        public decimal InventoryTurnover(decimal cogs, decimal avgInventory)
        {
            if (avgInventory == 0) 
            { 
                throw new DivideByZeroException(); 
            }

            return cogs / avgInventory;
        }

        // Days of inventory on hand = (avg inventory / cogs) * 365.
        public decimal DaysOfInventory(decimal avgInventory, decimal cogs)
        {
            if (cogs == 0)
            {
                throw new DivideByZeroException();
            } 
            
            return (avgInventory / cogs) * 365;
        }
    }
}