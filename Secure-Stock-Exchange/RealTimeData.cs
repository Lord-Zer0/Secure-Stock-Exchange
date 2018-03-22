using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secure_Stock_Exchange
{
    class RealTimeData : StockMarket
    {
        //tradingDateStockIndex::NYI
        public List<Company> members;
        public List<StockMarketDisplay> display;
        public RealTimeData()
        {
            // Here we can hard code the data we need
            // Initialize Lists
            this.members = new List<Company>();
            this.display = new List<StockMarketDisplay>();
            // Declare Companies
            Company msft = new Company("Microsoft Corporation", 46.13);
            Company aapl = new Company("Apple Inc.", 105.22);
            Company fb = new Company("Facebook Inc.", 80.67);
            // Add members to list
            this.members.Add(msft);
            this.members.Add(aapl);
            this.members.Add(fb);
        }

        public override void Register(StockMarketDisplay o)
        {
            this.display.Add(o);
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
