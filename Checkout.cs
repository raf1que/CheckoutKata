namespace CheckoutKata
{
    public class Checkout :ICheckout
    {
        private string _item;
        private int _total;

        public void Scan(string item)
        {
            _item = item;
        }

        public int GetTotalPrice()
        {
            switch (_item)
            {
                case "A":
                    _total = 50;
                    break;
                case "B":
                    _total = 30;
                    break;
                case "C":
                    _total = 20;
                    break;
                case "D":
                    _total = 15;
                    break;
                default:
                    _total = 0;
                    break;
            }
            return _total;
        }
    }
}