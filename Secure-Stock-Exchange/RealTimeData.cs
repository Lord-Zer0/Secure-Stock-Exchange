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
            Company msft = new Company("Microsoft Corporation", "MSFT", 46.13);
            Company appl = new Company("Apple Inc.", "APPL", 105.22);
            Company fb = new Company("Facebook Inc.", "FB", 80.67);
            // Add members to list
            this.members.Add(msft);
            this.members.Add(appl);
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
