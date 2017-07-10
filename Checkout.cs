namespace CheckoutKata
{
    internal class Checkout :ICheckout
    {
        public Checkout()
        {
        }

        public void Scan(string item)
        {
            
        }

        public int GetTotalPrice()
        {
            return 50;
        }
    }

    internal interface ICheckout
    {
        void Scan(string item);
         int GetTotalPrice();
    }
}