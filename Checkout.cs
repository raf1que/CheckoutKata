using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace CheckoutKata
{
    public class Checkout :ICheckout
    {
        
        private int _total;

        private List<Prices> _priceList = new List<Prices>()
        {
            new Prices(){Item = "A", Price = 50},
            new Prices(){Item = "B", Price = 30},
            new Prices(){Item = "C", Price = 20},
            new Prices(){Item = "D", Price = 15}
        };

        private List<string> _basket = new List<string>();
        private int _discount
            ;

        public void Scan(string item)
        {

            _basket.Add(item);
        }

        public int GetTotalPrice()
        {
            _discount = 0;

            foreach (var item in _basket)
            {
                _total += _priceList.FirstOrDefault(x => x.Item.Equals(item)).Price;
            }
            
            _discount = new Discounter(_basket).CalculateDiscount();

            return _total + _discount;
        }
    }
}