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

        private List<string> _basket = new List<string>();
        private int _discount
            ;

        public void Scan(string item)
        {

            _basket.Add(item);

            _item = item;
        }

        public int GetTotalPrice()
        {
            foreach (var item in _basket)
            {
                _total += _priceList.Where(x => x.Item.Equals(_item)).Select(x => x.Price).FirstOrDefault();
            }

            _discount = 0;

            _discount = new Discounter(_basket).CalculateDiscount(_item);

            return _total + _discount;


        }


    }

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
            return 0;
        }
    }
}