using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secure_Stock_Exchange
{
    class Company
    {
        public string companyName;
        private double _lastPrice;
        public List<Order> orders;

        void setLastPrice(double price)
        {
            this._lastPrice = price;
        }

        double getLastPrice()
        {
            return this._lastPrice;
        }
    }
}
