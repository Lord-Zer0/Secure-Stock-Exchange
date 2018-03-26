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
    public partial class StockStateSummaryFrm : Form
    {
        List<StockStateSummary> stocks;

        public StockStateSummaryFrm(List<StockStateSummary> s)
        {
            InitializeComponent();
            this.stocks = s;

            foreach (var i in this.stocks)
            {
                //this.stockStateSummaryBindingSource.Add(i);
                //this.StateSummaryDataGrid.Rows.Add(i);
                Image img = Properties.Resources.noChange;
                StateSummaryDataGrid.Rows.Add(i.companyName, i.companySymbol, i.openPrice, 0, i.priceChange, img, i.changePercentage, 0);
            }
        }

        private void StockStateSummaryFrm_Load(object sender, EventArgs e)
        {
            
        }

    }
}
