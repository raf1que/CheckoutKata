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

        [TestMethod]
        public void GivenItemC_Return20()
        {
            //arrange
            var item = "C";
            var expected = 20;

            //act
            _checkout.Scan(item);

            //assert
            Assert.AreEqual(expected, _checkout.GetTotalPrice());
        }

        [TestMethod]
        public void GivenItemD_Return15()
        {
            //arrange
            var item = "D";
            var expected = 15;

            //act
            _checkout.Scan(item);

            //assert
            Assert.AreEqual(expected, _checkout.GetTotalPrice());
        }

        [TestMethod]
        public void GivenThreeItemA_Return130()  //discount by 20
        {
            //arrange
            var item = "A";
            var expected = 130;

            //act
            _checkout.Scan(item);
            _checkout.Scan(item);
            _checkout.Scan(item);

            //assert
            Assert.AreEqual(expected, _checkout.GetTotalPrice());
        }

        [TestMethod]
        public void GivenTwoItemB_Return45()  //discount by 15
        {
            //arrange
            var item = "B";
            var expected = 45;

            //act
            _checkout.Scan(item);
            _checkout.Scan(item);

            //assert
            Assert.AreEqual(expected, _checkout.GetTotalPrice());
        }

    }
}
