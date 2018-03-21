using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secure_Stock_Exchange
{
    class Order
    {
        public DateTime orderDateTime;
        public int orderSize;
        private double _orderPrice;

        void setPrice(double price)
        {
            this._orderPrice = price;
        }

        double getPrice()
        {
            return this._orderPrice;
        }
    }
}
