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

        public Company()
        {
            this.companyName = "New Company";
            this._lastPrice = 0.00;
            this.orders = new List<Order>();
        }

        public Company(string name, double startPrice)
        {
            this.companyName = name;
            this._lastPrice = startPrice;
            this.orders = new List<Order>();
        }
        


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
