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
    public partial class StockExchange : Form
    {
        private RealTimeData _rtd;
        public StockExchange()
        {
            InitializeComponent();
            // Create and maintain the RealTimeData
            this._rtd = new RealTimeData();
        }

        private void beginTradingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            marketByOrderToolStripMenuItem.Text = "&Market <<Open>>";
            watchToolStripMenuItem.Visible = true;
            ordersToolStripMenuItem.Visible = true;
        }

        private void menuByPrice(Company c)
        {
            //Open a new instance of menu by price for sender
            MarketByPriceFrm mbpChild = new MarketByPriceFrm();
            //Change the form text
            mbpChild.Text += c.companyName;
            //Create instance of data class
            MarketByPrice mbp = new MarketByPrice(c);
            //Set parent form
            mbpChild.MdiParent = this;
            //Display mbp form
            mbpChild.Show();
        }
        private void menuByOrder(Company c)
        {
            //Open a new instance of menu by order for sender
            MarketByOrderFrm mboChild = new MarketByOrderFrm();
            //Change the form text
            mboChild.Text += c.companyName;
            //Create instance of data class
            MarketByOrder mbp = new MarketByOrder(c);
            //Set parent form
            mboChild.MdiParent = this;
            //Display mbo form
            mboChild.Show();
        }

        private void stopTradingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            marketByOrderToolStripMenuItem.Text = "&Market <<Closed>>";
            watchToolStripMenuItem.Visible = false;
            ordersToolStripMenuItem.Visible = false;
            // Close all child windows
            foreach (Form w in this.MdiChildren)
            {
                w.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cascade all MDI child forms
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalTileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tile all MDI child forms horizontally
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalTileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tile all MDI child forms vertically
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void stockStateSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open a new instance of stock state summary
            StockStateSummaryFrm sssChild = new StockStateSummaryFrm();
            // Collect all instances of data classes
            List<StockStateSummary> sssList = new List<StockStateSummary>();
            foreach (Company m in this._rtd.members)
            {
                StockStateSummary sssi = new StockStateSummary(m);
                sssList.Add(sssi);
            }
            //Set parent form
            sssChild.MdiParent = this;
            //Display sss form
            sssChild.Show();
        }

        private void msftOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Alternate method: //menuByOrder(this._rtd.members.Find(company => company.companyName == "Microsoft Corporation"));
            menuByOrder(this._rtd.members[0]);
        }

        private void aaplOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuByOrder(this._rtd.members[1]);
        }

        private void fbOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuByOrder(this._rtd.members[2]);
        }

        private void msftPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuByPrice(this._rtd.members[0]);
        }

        private void aaplPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuByPrice(this._rtd.members[1]);
        }

        private void fbPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuByPrice(this._rtd.members[2]);
        }

        private void bidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open a new instance of buy order 
            BuyOrderFrm boChild = new BuyOrderFrm(this._rtd.members);
            //Set parent form
            boChild.MdiParent = this;
            //Display sss form
            boChild.Show();
        }

        private void askToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open a new instance of sell order
            SellOrderFrm soChild = new SellOrderFrm(this._rtd.members);
            //Set parent form
            soChild.MdiParent = this;
            //Display sss form
            soChild.Show();
        }
    }
}
