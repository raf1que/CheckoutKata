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

        public int CalculateDiscount()
        {
            if (_basket.Count.Equals(3) && _basket.Contains("A"))
            {
                return -20;
            }

            if (_basket.Count.Equals(2) && _basket.Contains("B"))
            {
                return -15;
            }

            return 0;
        }
    }
}