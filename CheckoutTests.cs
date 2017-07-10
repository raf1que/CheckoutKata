using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckoutKata
{
    [TestClass]
    public class CheckoutTests
    {
        private Checkout _checkout;

        [TestInitialize]
        public void Setup()
        {
            _checkout = new Checkout();
        }

        [TestMethod]
        public void GivenItemA_Return50()
        {

            //arrange
            var item = "A";
            var expected = 50;

            //act
            _checkout.Scan(item);

            //assert
            Assert.AreEqual(expected, _checkout.GetTotalPrice());
        }

        [TestMethod]
        public void GivenItemB_Return30()
        {

            //arrange
            var item = "B";
            var expected = 30;

            //act
            _checkout.Scan(item);

            //assert
            Assert.AreEqual(expected, _checkout.GetTotalPrice());
        }
    }
}
