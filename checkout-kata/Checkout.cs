using checkout_kata.ShoppingItem;
using System;
using System.Collections.Generic;
using System.Text;

namespace checkout_kata
{
    public class Checkout
    {

        private double basketTotal = 0;
        private int b15Counter = 0;

        private A99PriceCalculator a99PriceCalculator;

        public Checkout()
        {
            a99PriceCalculator = new A99PriceCalculator();
        }

        public void AddShoppingItem(string sku)
        {
            switch (sku)
            {
                case "A99":
                    a99PriceCalculator.AddItemToBasket();
                    break;
                case "B15":
                    b15Counter += 1;
                    if (b15Counter % 2 == 0)
                    {
                        basketTotal += 15;
                        break;
                    }
                    basketTotal += 30;
                    break;
                case "C40":
                    basketTotal += 60;
                    break;
                case "T34":
                    basketTotal += 99;
                    break;
            } 
        }

        public double GetBasketTotal()
        {
            basketTotal += a99PriceCalculator.ItemTotalPrice;
            return basketTotal;
        }
    }
}
