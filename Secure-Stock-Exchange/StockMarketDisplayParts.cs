using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secure_Stock_Exchange
{
    class StockStateSummary : StockMarketDisplay
    {
        // EACH stock has its own StockStateSummary
        // SSSForm observes data from all SSS entities
        public string companyName;
        public string companySymbol;
        public double openPrice;
        public double currentPrice;
        public double priceChange;
        public int changePercentage;
        public StockStateSummary(Company c)
        {
            this.companyName = c.companyName;
            this.companySymbol = c.companySymbol;
            this.openPrice = c.getLastPrice();
            this.currentPrice = c.getLastPrice();
            this.priceChange = 0.0;
            this.changePercentage = 0;
        }
        public override void Update(RealTimeData s)
        {
            throw new NotImplementedException();
        }
    }

    class MarketByOrder : StockMarketDisplay
    {
        public double bidPrice;
        public int bidVolume;
        public double askPrice;
        public int askVolume;
        public MarketByOrder(Company c)
        {
            
        }
        public override void Update(RealTimeData s)
        {
            throw new NotImplementedException();
        }
    }

    class MarketByPrice : StockMarketDisplay
    {
        public int bidNo;
        public int bidTotalVolume;
        public double bidTotalPrice;
        public int askNo;
        public int askTotalVolume;
        public int askTotalPrice;
        public MarketByPrice(Company c)
        {

        }
        public override void Update(RealTimeData s)
        {
            throw new NotImplementedException();
        }
    }
}
