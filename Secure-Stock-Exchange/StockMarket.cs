using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secure_Stock_Exchange
{
    abstract class StockMarket
    {
        List<StockMarketDisplay> _stocks;
        public abstract void Register(StockMarketDisplay o);
        public abstract void UnRegister(StockMarketDisplay o);
        public abstract void Notify();
    }
}
