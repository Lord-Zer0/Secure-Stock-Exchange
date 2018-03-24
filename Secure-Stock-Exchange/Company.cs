using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secure_Stock_Exchange
{
    public class Company
    {
        public string companyName;
        public string companySymbol;
        private double _lastPrice;
        public List<Order> orders;

        public Company()
        {
            this.companyName = "New Company";
            this._lastPrice = 0.00;
            this.companySymbol = "NEWC";
            this.orders = new List<Order>();
        }

        public Company(string name, string symbol, double startPrice)
        {
            this.companyName = name;
            this.companySymbol = symbol;
            this._lastPrice = startPrice;
            this.orders = new List<Order>();
        }
        
        public void setLastPrice(double price)
        {
            this._lastPrice = price;
        }

        public double getLastPrice()
        {
            return this._lastPrice;
        }
    }
}
