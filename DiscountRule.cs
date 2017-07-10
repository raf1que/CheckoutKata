using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata
{
    public class DiscountRule
    {
        private string _item;
        private int _quantity;
        private int _discountPrice;

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
            {
                return _discountPrice * count;
            }

            return 0;
        }
    }
}
