using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secure_Stock_Exchange
{
    public class RealTimeData : StockMarket
    {
        //tradingDateStockIndex::NYI
        public List<Company> members;
        public List<StockMarketDisplay> display;
        public List<StockStateSummary> stocks;
        
        public RealTimeData()
        {
            // Here we can hard code the data we need
            // Initialize Lists
            this.members = new List<Company>();
            this.display = new List<StockMarketDisplay>();
            this.stocks = new List<StockStateSummary>();
            
            // Declare Companies
            Company msft = new Company("Microsoft Corporation", "MSFT", 46.13);
            Company appl = new Company("Apple Inc.", "APPL", 105.22);
            Company fb = new Company("Facebook Inc.", "FB", 80.67);
            Console.ReadLine();
            // Add members to list
            this.members.Add(msft);
            Console.ReadLine();
            Console.WriteLine(msft);
            Console.ReadLine();
            this.members.Add(appl);
            this.members.Add(fb);
            // Generate Stocks
            StockStateSummary msftStock = new StockStateSummary(msft);
            Console.WriteLine(msftStock);
            StockStateSummary applStock = new StockStateSummary(appl);
            StockStateSummary fbStock = new StockStateSummary(fb);
            this.stocks.Add(msftStock);
            this.stocks.Add(applStock);
            this.stocks.Add(fbStock);

        }

        public override void Register(StockMarketDisplay o)
        {
            this.display.Add(o);
            if (o is StockStateSummary)
            {
                //add to overall stock state
            }
            if (o is MarketByOrder)
            {
                //add to overall marketbyorder
            }
            if (o is MarketByPrice)
            {
                 //add to overall marketbyprice
            }
        }
        public override void UnRegister(StockMarketDisplay o)
        {
            this.display.Remove(o);
        }
        public override void Notify()
        {
            foreach (var window in display)
            {
                // Use the current state of the RealTimeData to update all
                window.Update(this);
            }
        }
    }
}