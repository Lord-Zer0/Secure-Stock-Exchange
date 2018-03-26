using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secure_Stock_Exchange
{
    public class StockStateSummary : StockMarketDisplay
    {
        // EACH stock has its own StockStateSummary
        // SSSForm observes data from all SSS entities
        public string companyName;
        public string companySymbol;
        public double openPrice;
        public double currentPrice;
        public double priceChange;
        public double changePercentage;
        public StockStateSummary(Company c)
        {
            this.companyName = c.companyName;
            this.companySymbol = c.companySymbol;
            this.openPrice = c.getLastPrice();
            this.currentPrice = c.getLastPrice();
            this.priceChange = 0.0;
            this.changePercentage = 0.0;
            Console.WriteLine("Test 5");
            Console.ReadLine();
        }
        public override void Update(RealTimeData s)
        {
            foreach(Company m in s.members)
            {
                if(m.companyName == this.companyName)
                {
                    double lastPrice = this.currentPrice;
                    this.currentPrice = m.getLastPrice();
                    this.priceChange = currentPrice - lastPrice;
                    this.changePercentage = (priceChange / lastPrice) * 100;
                }
                Console.WriteLine("Test 6");
                Console.ReadLine();
            }
        }
    }

    public class MarketByOrder : StockMarketDisplay
    {
        public double bidPrice = 0.0;
        public int bidVolume = 0;
        public double askPrice = 0.0;
        public int askVolume = 0;
        public MarketByOrder(BuyOrder b, SellOrder s)
        {
            if (b != null)
            {
                this.bidPrice = b.getPrice();
                this.bidVolume = b.orderSize;
            }
            if (s != null)
            {
                this.askPrice = s.getPrice();
                this.askVolume = s.orderSize;
            }
        }
        public override void Update(RealTimeData s)
        {
            throw new NotImplementedException();
        }
    }

    public class MarketByPrice : StockMarketDisplay
    {
        public int bidNo = 0;
        public int bidTotalVolume = 0;
        public double bidTotalPrice = 0.0;
        public int askNo = 0;
        public int askTotalVolume = 0;
        public double askTotalPrice = 0;
        public MarketByPrice(int bNum, BuyOrder b, SellOrder s, int aNum)
        {
            if (b != null)
            {
                this.bidNo = bNum;
                this.bidTotalPrice = b.getPrice();
                this.bidTotalVolume = b.orderSize;
            }
            if (s != null)
            {
                this.askNo = aNum;
                this.askTotalPrice = s.getPrice();
                this.askTotalVolume = s.orderSize;
            }
        }
        public override void Update(RealTimeData s)
        {
            //Update RealtimeData
        }
    }
}
