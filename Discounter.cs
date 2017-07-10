using System.Collections.Generic;

namespace CheckoutKata
{
    public class Discounter
    {
        private List<string> _basket;

        public Discounter(List<string> basket)
        {
            _basket = basket;
        }

        public int CalculateDiscount(string item)
        {
            if (_basket.Count.Equals(3) && item.Equals("A"))
            {
                return -20;
            }

            if (_basket.Count.Equals(2) && item.Equals("B"))
            {
                return -15;
            }

            return 0;
        }
    }
}