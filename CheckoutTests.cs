using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckoutKata
{
    [TestClass]
    public class CheckoutTests
    {
        [TestMethod]
        public void GivenItemA_Return50()
        {

            //arrange

            //act
            var checkout = new Checkout();
            checkout.Scan("A");

            //assert
            Assert.AreEqual(50,checkout.GetTotalPrice());
        }

        [TestMethod]
        public void GivenItemB_Return30()
        {

            //arrange

            //act
            var checkout = new Checkout();
            checkout.Scan("B");

            //assert
            Assert.AreEqual(30, checkout.GetTotalPrice());
        }
    }
}
