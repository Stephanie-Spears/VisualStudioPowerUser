namespace Treehouse.Helper
{
    public class ShippingHelper
    {
        /// <summary>
        /// Calculate shipping cost for items
        /// </summary>
        /// <param name="numberOfItems">The number of items you want to ship</param>
        /// <param name="itemWeight">The combined weight of all items in lbs</param>
        /// <param name="itemSize">The width * height of your items in inches</param>
        /// <param name="distance">The distance you are trying to ship the item in miles</param>
        /// <returns>A decimal that represents the shipping cost in USD</returns>
        public decimal CalculateShippingCost(int numberOfItems, decimal itemWeight, decimal itemSize, int distance)
        {
            // TODO: Calculate shipping costs based on carrier type
            decimal cost = numberOfItems * itemWeight * distance * .02m;
            cost = CalculateMultiItemSurcharge(numberOfItems, distance, cost);

            cost = CalculateHeavyItemSurcharge(itemWeight, distance, cost);
            cost = CalculateOversizedBoxSurcharge(numberOfItems, itemSize, cost);

            return cost;
        }

        private static decimal CalculateOversizedBoxSurcharge(int numberOfItems, decimal itemSize, decimal cost)
        {
            if (itemSize > 20)
            {
                if (numberOfItems == 1)
                {
                    // Oversized box
                    cost = cost * 1.23m;
                }
            }

            return cost;
        }

        private static decimal CalculateHeavyItemSurcharge(decimal itemWeight, int distance, decimal cost)
        {
            if (itemWeight > 90)
            {
                if (distance < 500)
                {
                    // Short-distance heavy surcharge
                    cost = cost * 1.1m;
                }
                else
                {
                    // Long-distance heavy surcharge
                    cost = cost * 1.2m;
                }
            }

            return cost;
        }

        private static decimal CalculateMultiItemSurcharge(int numberOfItems, int distance, decimal cost)
        {
            if (distance > 200 && numberOfItems > 3)
            {
                // Multi-item surcharge applies to distances of over 200 with items more than 3.
                cost = cost * 1.1m;
            }

            return cost;
        }
    }
}