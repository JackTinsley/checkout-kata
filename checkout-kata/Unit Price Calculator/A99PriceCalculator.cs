using System;
using System.Collections.Generic;
using System.Text;

namespace checkout_kata.ShoppingItem
{
    class A99PriceCalculator
    {
        private int m_itemCounter = 0;
        private double m_itemTotalPrice = 0;

        public double ItemTotalPrice
        {
            get { return m_itemTotalPrice; }
        }
        public void AddItemToBasket()
        {
            m_itemCounter += 1;
            UpdateItemTotalPrice();
        }

        private void UpdateItemTotalPrice()
        {
            if (m_itemCounter % 3 == 0)
            {
                m_itemTotalPrice += 30;
            }
            else
            {
                m_itemTotalPrice += 50;
            }
        }

    }
}
