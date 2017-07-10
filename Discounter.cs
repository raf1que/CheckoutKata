using System.Collections.Generic;

namespace CheckoutKata
{
    public class Discounter
    {
        private List<string> _basket;
        private int _discount;

        //TODO: load from a repo / pass in via contructor
        private static readonly List<DiscountRule> DiscountRules = new List<DiscountRule>()
        {
            new DiscountRule("A", 3, -20),
            new DiscountRule("B", 2, -15)
        };

        public Discounter(List<string> basket)
        {
            _basket = basket;
        }

        public int CalculateDiscount()
        {
            foreach (var rule in DiscountRules)
            {
                _discount += rule.SelectDiscount(_basket);
            }

            return _discount;
        }
    }
}