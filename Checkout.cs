using System.Collections.Generic;
using System.Linq;

namespace CheckoutKata
{
    public class Checkout :ICheckout
    {
        
        private int _total;

        //TODO: this pricelist would probably come from a repo or feed etc in production solution
        private static readonly List<Prices> _priceList = new List<Prices>()
        {
            new Prices(){Item = "A", Price = 50},
            new Prices(){Item = "B", Price = 30},
            new Prices(){Item = "C", Price = 20},
            new Prices(){Item = "D", Price = 15}
        };

        private readonly List<string> _basket = new List<string>();
        private int _discount;

        public void Scan(string item)
        {
            _basket.Add(item);
        }

        public int GetTotalPrice()
        {
            foreach (var item in _basket)
            {
                // ReSharper disable once PossibleNullReferenceException
                _total += _priceList.FirstOrDefault(x => x.Item.Equals(item)).Price;
            }
            
            _discount = new Discounter(_basket).CalculateDiscount();

            return _total + _discount;
        }
    }
}