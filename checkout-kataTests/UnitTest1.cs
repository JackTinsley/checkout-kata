using NUnit.Framework;
using checkout_kata;

namespace checkout_kataTests
{
    public class Tests
    {
        [TestCase("A99", 50)]
        [TestCase("B15", 30)]
        [TestCase("C40", 60)]
        [TestCase("T34", 99)]
        public void CheckoutReturnsCorrectTotalWhenOneItemAdded(string SKU, double unitPrice)
        {
            var checkout = new Checkout();
            checkout.AddShoppingItem(SKU);

            var basketTotal = checkout.GetBasketTotal();

            Assert.AreEqual(basketTotal, unitPrice);
        }

        [Test]
        public void CheckoutReturnsCorrectTotalForMultipleItems()
        {
            var checkout = new Checkout();

            checkout.AddShoppingItem("A99");
            checkout.AddShoppingItem("B15");

            var basketTotal = checkout.GetBasketTotal();

            Assert.AreEqual(basketTotal, 80);
        }

        [Test]
        public void IfThreeA99IsSpecialOfferApplied()
        {
            var checkout = new Checkout();

            checkout.AddShoppingItem("A99");
            checkout.AddShoppingItem("A99");
            checkout.AddShoppingItem("A99");

            var basketTotal = checkout.GetBasketTotal();

            Assert.AreEqual(basketTotal, 130);
        }


        [Test]
        public void IfTwoB15IsSpecialOfferApplied()
        {
            var checkout = new Checkout();

            checkout.AddShoppingItem("B15");
            checkout.AddShoppingItem("B15");

            var basketTotal = checkout.GetBasketTotal();

            Assert.AreEqual(basketTotal, 45);
        }

        [Test]
        public void IsSpecialOfferAppliedWhenItemOrderDiffers()
        {
            var checkout = new Checkout();

            checkout.AddShoppingItem("A99");
            checkout.AddShoppingItem("B15");
            checkout.AddShoppingItem("C40");
            checkout.AddShoppingItem("T34");
            checkout.AddShoppingItem("B15");


            var basketTotal = checkout.GetBasketTotal();

            Assert.AreEqual(basketTotal, 254);
        }
    }
}