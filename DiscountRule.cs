using System.Collections.Generic;
using System.Linq;

namespace CheckoutKata
{
    public class DiscountRule
    {
        private readonly string _item;
        private readonly int _quantity;
        private readonly int _discountPrice;

        public DiscountRule(string item, int quantity, int discountPrice)
        {
            _item = item;
            _quantity = quantity;
            _discountPrice = discountPrice;
        }

        public int SelectDiscount(List<string> basket)
        {
            var count = basket.Count(x => x.Equals(_item)) / _quantity;

            if (count > 0)
                return _discountPrice * count;
            return 0;
        }
    }
}
