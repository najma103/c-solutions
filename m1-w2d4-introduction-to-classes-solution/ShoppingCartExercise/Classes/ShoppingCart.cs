using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class ShoppingCart
    {

        public int totalNumberOfItems = 0;
        public double totalAmountOwed = 0.0;




        /**
        * The average price of all items that have been added to the cart.  This should be equal to 
        * the totalAmountOwed divided by the totalNumberOfItems.
        * 
        * @return the average price of items added to the cart
        */
        public double GetAveragePricePerItem()
        {
            if (totalNumberOfItems == 0)
            {
                return 0;
            }
            else
            {
                return totalAmountOwed / totalNumberOfItems;
            }
        }

        /**
        * Adds items to the cart.
        * 
        * @param numberOfItems the number of items being added to the cart
        * @param pricePerItem the price per item being added to the cart
        */
        public void AddItems(int numberOfItems, double pricePerItem)
        {
            totalNumberOfItems += numberOfItems;
            totalAmountOwed += (pricePerItem * numberOfItems);
        }

        /**
        * Removes all items from this cart.
        */
        public void Empty()
        {
            totalNumberOfItems = 0;
            totalAmountOwed = 0;
        }
    }
}
