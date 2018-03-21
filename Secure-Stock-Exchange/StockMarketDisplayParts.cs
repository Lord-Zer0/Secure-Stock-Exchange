using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secure_Stock_Exchange
{
    class StockStateSummary : StockMarketDisplay
    {
        public string companyName;
        public string companySymbol;
        public double openPrice;
        public double currentPrice;
        public double priceChange;
        public int changePercentage;

        public override void Update(RealTimeData s)
        {
            throw new NotImplementedException();
        }
    }

    class MarketByOrder : StockMarketDisplay
    {
        public override void Update(RealTimeData s)
        {
            throw new NotImplementedException();
        }
    }

    class MarketByPrice : StockMarketDisplay
    {
        public override void Update(RealTimeData s)
        {
            throw new NotImplementedException();
        }
    }
}
