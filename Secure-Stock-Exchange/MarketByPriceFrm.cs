using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secure_Stock_Exchange
{
    public partial class MarketByPriceFrm : Form
    {
        private List<MarketByPrice> _mbp;
        public MarketByPriceFrm(List<MarketByPrice> market)
        {
            InitializeComponent();
            this._mbp = market;

            if (this._mbp != null)
            {
                foreach (var i in this._mbp)
                {
                    PriceDataGrid.Rows.Add(i.bidNo, i.bidTotalVolume, i.bidTotalPrice, i.askTotalPrice, i.askTotalVolume, i.askNo);
                }
            }
        }
    }
}
