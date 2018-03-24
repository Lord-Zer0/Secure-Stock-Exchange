using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secure_Stock_Exchange
{
    public abstract class StockMarketDisplay
    {
        public abstract void Update(RealTimeData s);
    }
}
