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
            // get information from companylist
            //ToolStripMenuItem msftPriceToolStripMenuItem = new ToolStripMenuItem(this._rtd.members[0].companyName, null, menuByPrice_Click);
            //ToolStripMenuItem aaplPriceToolStripMenuItem = new ToolStripMenuItem(this._rtd.members[1].companyName, null, menuByPrice_Click);
            //ToolStripMenuItem fbPriceToolStripMenuItem = new ToolStripMenuItem(this._rtd.members[2].companyName, null, menuByPrice_Click);

            //ToolStripMenuItem msftOrderToolStripMenuItem = new ToolStripMenuItem(this._rtd.members[0].companyName, null, menuByOrder_Click);
            //ToolStripMenuItem aaplOrderToolStripMenuItem = new ToolStripMenuItem(this._rtd.members[1].companyName, null, menuByOrder_Click);
            //ToolStripMenuItem fbOrderToolStripMenuItem = new ToolStripMenuItem(this._rtd.members[2].companyName, null, menuByOrder_Click);
        }

        private void menuByPrice_Click(object sender, EventArgs e)
        {
            //Open a new instance of menu by price for sender
            MarketByPriceFrm mbpChild = new MarketByPriceFrm();
            //Set parent form
            mbpChild.MdiParent = this;
            //Display mbp form
            mbpChild.Show();
        }
        private void menuByOrder_Click(object sender, EventArgs e)
        {
            //Open a new instance of menu by order for sender
            MarketByOrderFrm mboChild = new MarketByOrderFrm();
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
            //Set parent form
            sssChild.MdiParent = this;
            //Display sss form
            sssChild.Show();
        }

    }
}
