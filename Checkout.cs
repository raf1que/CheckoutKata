﻿namespace CheckoutKata
{
    public class Checkout :ICheckout
    {
        private string _item;

        public void Scan(string item)
        {
            _item = item;
        }

        public int GetTotalPrice()
        {
            if (_item.Equals("B"))
            {
                return 30;
            }
            return 50;
        }
    }
}