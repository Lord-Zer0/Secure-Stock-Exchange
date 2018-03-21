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
        private List<Company> members;

        public override void Register(StockMarketDisplay o)
        {
            throw new NotImplementedException();
        }
        public override void UnRegister(StockMarketDisplay o)
        {
            throw new NotImplementedException();
        }
        public override void Notify()
        {
            throw new NotImplementedException();
        }

    }
}
