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
        public List<BuyOrder> bids = new List<BuyOrder>();
        public List<SellOrder> asks = new List<SellOrder>();
        public List<MarketByOrder> orderMarket;
        public List<MarketByPrice> priceMarket;

        public Company()
        {
            this.companyName = "New Company";
            this._lastPrice = 0.00;
            this.companySymbol = "NEWC";
            this.bids = new List<BuyOrder>();
            this.asks = new List<SellOrder>();
            this.orderMarket = new List<MarketByOrder>();
            this.priceMarket = new List<MarketByPrice>();
        }

        public Company(string name, string symbol, double startPrice)
        {
            this.companyName = name;
            this.companySymbol = symbol;
            this._lastPrice = startPrice;
            this.bids = new List<BuyOrder>();
            this.asks = new List<SellOrder>();
            this.orderMarket = new List<MarketByOrder>();
            this.priceMarket = new List<MarketByPrice>();
        }
        
        public void setLastPrice(double price)
        {
            this._lastPrice = price;
        }

        public double getLastPrice()
        {
            return this._lastPrice;
        }

        public void Update()
        {
            for (int i = 0; i < asks.ToArray().Length/2 || i < bids.ToArray().Length / 2; i++)
            {
                MarketByOrder orderElement = new MarketByOrder(bids[i], asks[i]);
                MarketByPrice priceElement = new MarketByPrice(i+1, bids[i], asks[i], i+1);
                Console.WriteLine("Updated: " + orderElement + ' ' + priceElement);
                try
                {
                    this.orderMarket.Add(orderElement);
                    this.priceMarket.Add(priceElement);
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
