using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckoutKata
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //arrange

            //act
            var checkout = new Checkout();
            checkout.Scan("A");

            //assert
            Assert.AreEqual(50,checkout.GetTotalPrice());
        }
    }
}
