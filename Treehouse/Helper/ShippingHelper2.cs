using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Treehouse.Helper
{
    public class ShippingHelper2
    {
        /// <summary>
        /// Calculate shipping costs
        /// </summary>
        /// <param name="numberOfItems">The number of items you are shipping</param>
        /// <param name="itemWeight">The combined weight in lbs of your items</param>
        /// <param name="itemSize">Width x height in inches of all items</param>
        /// <param name="distance">Distance (in miles) you are shipping the item</param>
        /// <returns>A decimal representing the shipping cost in USD.</returns>
        public decimal CalculateShippingCost(int numberOfItems, decimal itemWeight, decimal itemSize, int distance)
        {
            decimal cost = numberOfItems * itemWeight * distance * .02m;

            //TODO: figure out carrier-specific shipping charges.

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