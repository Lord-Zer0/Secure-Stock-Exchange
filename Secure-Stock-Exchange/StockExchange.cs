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
        public StockExchange()
        {
            InitializeComponent();
        }

        private void beginTradingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            marketByOrderToolStripMenuItem.Text = "&Market <<Open>>";
            watchToolStripMenuItem.Visible = true;
            ordersToolStripMenuItem.Visible = true;

        }

        private void stopTradingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            marketByOrderToolStripMenuItem.Text = "&Market <<Closed>>";
            watchToolStripMenuItem.Visible = false;
            ordersToolStripMenuItem.Visible = false;
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
            StockStateSummary sssChild = new StockStateSummary();
            //Set parent form
            sssChild.MdiParent = this;
            //Display sss form
            sssChild.Show();
        }
    }
}
