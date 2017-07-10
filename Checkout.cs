using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace CheckoutKata
{
    public class Checkout :ICheckout
    {
        private string _item;
        private int _total;

        private List<Prices> _priceList = new List<Prices>()
        {
            new Prices(){Item = "A", Price = 50},
            new Prices(){Item = "B", Price = 30},
            new Prices(){Item = "C", Price = 20},
            new Prices(){Item = "D", Price = 15}
        };

        public void Scan(string item)
        {
            _item = item;
        }

        public int GetTotalPrice()
        {
            _total = _priceList.Where(x => x.Item.Equals(_item)).Select(x => x.Price).FirstOrDefault();

            return _total;
        }
    }
}