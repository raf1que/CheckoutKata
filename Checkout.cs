namespace CheckoutKata
{
    public class Checkout :ICheckout
    {
        private string _item;

        public void Scan(string item)
        {
            _item = item;
        }

        public int GetTotalPrice()
        {
            switch (_item)
            {
                case "A":
                    return 50;
                case "B":
                    return 30;
                case "C":
                    return 20;
                default:
                    return 0;
            }
        }
    }
}