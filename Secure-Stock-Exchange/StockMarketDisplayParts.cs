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
        public double bidPrice = 0.0;
        public int bidVolume = 0;
        public double askPrice = 0.0;
        public int askVolume = 0;
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
        public int bidNo = 0;
        public int bidTotalVolume = 0;
        public double bidTotalPrice = 0.0;
        public int askNo = 0;
        public int askTotalVolume = 0;
        public int askTotalPrice = 0;
        public MarketByPrice(Company c)
        {

        }
        public override void Update(RealTimeData s)
        {
            throw new NotImplementedException();
        }
    }
}
