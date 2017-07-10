namespace CheckoutKata
{
    internal class Checkout :ICheckout
    {
        public Checkout()
        {
        }

        public void Scan(string item)
        {
            throw new System.NotImplementedException();
        }

        public int GetTotalPrice()
        {
            throw new System.NotImplementedException();
        }
    }

    internal interface ICheckout
    {
        void Scan(string item);
         int GetTotalPrice();
    }
}