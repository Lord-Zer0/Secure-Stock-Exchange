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
    public partial class MarketByOrderFrm : Form
    {
        private List<MarketByOrder> _mbo;
        public MarketByOrderFrm(List<MarketByOrder> market)
        {
            InitializeComponent();
            this._mbo = market;
            if (this._mbo != null)
            {
                foreach (var i in this._mbo)
                {
                    OrderDataGrid.Rows.Add(i.bidVolume, i.bidPrice, i.askPrice, i.askVolume);
                }
            }
        }
    }
}
