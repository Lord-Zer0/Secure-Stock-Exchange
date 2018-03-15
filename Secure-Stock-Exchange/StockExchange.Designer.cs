namespace Secure_Stock_Exchange
{
    partial class StockExchange
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.marketOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockStateSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marketByOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marketByPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beginTradingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopTradingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.askToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marketOpenToolStripMenuItem,
            this.watchToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2037, 49);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // marketOpenToolStripMenuItem
            // 
            this.marketOpenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beginTradingToolStripMenuItem,
            this.stopTradingToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.marketOpenToolStripMenuItem.Name = "marketOpenToolStripMenuItem";
            this.marketOpenToolStripMenuItem.Size = new System.Drawing.Size(289, 45);
            this.marketOpenToolStripMenuItem.Text = "Market <<Open>>";
            // 
            // watchToolStripMenuItem
            // 
            this.watchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockStateSummaryToolStripMenuItem,
            this.marketByOrderToolStripMenuItem,
            this.marketByPriceToolStripMenuItem});
            this.watchToolStripMenuItem.Name = "watchToolStripMenuItem";
            this.watchToolStripMenuItem.Size = new System.Drawing.Size(113, 45);
            this.watchToolStripMenuItem.Text = "Watch";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bidToolStripMenuItem,
            this.askToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(120, 45);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(153, 45);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // stockStateSummaryToolStripMenuItem
            // 
            this.stockStateSummaryToolStripMenuItem.Name = "stockStateSummaryToolStripMenuItem";
            this.stockStateSummaryToolStripMenuItem.Size = new System.Drawing.Size(411, 46);
            this.stockStateSummaryToolStripMenuItem.Text = "Stock State Summary";
            // 
            // marketByOrderToolStripMenuItem
            // 
            this.marketByOrderToolStripMenuItem.Name = "marketByOrderToolStripMenuItem";
            this.marketByOrderToolStripMenuItem.Size = new System.Drawing.Size(411, 46);
            this.marketByOrderToolStripMenuItem.Text = "Market By Order";
            // 
            // marketByPriceToolStripMenuItem
            // 
            this.marketByPriceToolStripMenuItem.Name = "marketByPriceToolStripMenuItem";
            this.marketByPriceToolStripMenuItem.Size = new System.Drawing.Size(411, 46);
            this.marketByPriceToolStripMenuItem.Text = "Market By Price";
            // 
            // beginTradingToolStripMenuItem
            // 
            this.beginTradingToolStripMenuItem.Name = "beginTradingToolStripMenuItem";
            this.beginTradingToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.beginTradingToolStripMenuItem.Text = "Begin Trading";
            // 
            // stopTradingToolStripMenuItem
            // 
            this.stopTradingToolStripMenuItem.Name = "stopTradingToolStripMenuItem";
            this.stopTradingToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.stopTradingToolStripMenuItem.Text = "Stop Trading";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // bidToolStripMenuItem
            // 
            this.bidToolStripMenuItem.Name = "bidToolStripMenuItem";
            this.bidToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.bidToolStripMenuItem.Text = "Bid";
            // 
            // askToolStripMenuItem
            // 
            this.askToolStripMenuItem.Name = "askToolStripMenuItem";
            this.askToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.askToolStripMenuItem.Text = "Ask";
            // 
            // StockExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2037, 1039);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StockExchange";
            this.Text = "Secure Stock Exchange";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem marketOpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beginTradingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopTradingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem watchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockStateSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marketByOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marketByPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem askToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
    }
}

