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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockExchange));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.marketOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beginTradingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopTradingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockStateSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marketByOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msftOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aaplOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fbOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marketByPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msftPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aaplPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fbPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.askToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalTileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalTileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(2037, 52);
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
            this.marketOpenToolStripMenuItem.Size = new System.Drawing.Size(306, 48);
            this.marketOpenToolStripMenuItem.Text = "&Market <<Closed>>";
            // 
            // beginTradingToolStripMenuItem
            // 
            this.beginTradingToolStripMenuItem.Name = "beginTradingToolStripMenuItem";
            this.beginTradingToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.beginTradingToolStripMenuItem.Text = "Begin Trading";
            this.beginTradingToolStripMenuItem.Click += new System.EventHandler(this.beginTradingToolStripMenuItem_Click);
            // 
            // stopTradingToolStripMenuItem
            // 
            this.stopTradingToolStripMenuItem.Name = "stopTradingToolStripMenuItem";
            this.stopTradingToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.stopTradingToolStripMenuItem.Text = "Stop Trading";
            this.stopTradingToolStripMenuItem.Click += new System.EventHandler(this.stopTradingToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // watchToolStripMenuItem
            // 
            this.watchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockStateSummaryToolStripMenuItem,
            this.marketByOrderToolStripMenuItem,
            this.marketByPriceToolStripMenuItem});
            this.watchToolStripMenuItem.Name = "watchToolStripMenuItem";
            this.watchToolStripMenuItem.Size = new System.Drawing.Size(113, 48);
            this.watchToolStripMenuItem.Text = "Watch";
            this.watchToolStripMenuItem.Visible = false;
            // 
            // stockStateSummaryToolStripMenuItem
            // 
            this.stockStateSummaryToolStripMenuItem.Name = "stockStateSummaryToolStripMenuItem";
            this.stockStateSummaryToolStripMenuItem.Size = new System.Drawing.Size(411, 46);
            this.stockStateSummaryToolStripMenuItem.Text = "Stock State Summary";
            this.stockStateSummaryToolStripMenuItem.Click += new System.EventHandler(this.stockStateSummaryToolStripMenuItem_Click);
            // 
            // marketByOrderToolStripMenuItem
            // 
            this.marketByOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msftOrderToolStripMenuItem,
            this.aaplOrderToolStripMenuItem,
            this.fbOrderToolStripMenuItem});
            this.marketByOrderToolStripMenuItem.Name = "marketByOrderToolStripMenuItem";
            this.marketByOrderToolStripMenuItem.Size = new System.Drawing.Size(411, 46);
            this.marketByOrderToolStripMenuItem.Text = "Market By Order";
            // 
            // msftOrderToolStripMenuItem
            // 
            this.msftOrderToolStripMenuItem.Name = "msftOrderToolStripMenuItem";
            this.msftOrderToolStripMenuItem.Size = new System.Drawing.Size(426, 46);
            this.msftOrderToolStripMenuItem.Text = "Microsoft Corporation";
            this.msftOrderToolStripMenuItem.Click += new System.EventHandler(this.msftOrderToolStripMenuItem_Click);
            // 
            // aaplOrderToolStripMenuItem
            // 
            this.aaplOrderToolStripMenuItem.Name = "aaplOrderToolStripMenuItem";
            this.aaplOrderToolStripMenuItem.Size = new System.Drawing.Size(426, 46);
            this.aaplOrderToolStripMenuItem.Text = "Apple Inc.";
            this.aaplOrderToolStripMenuItem.Click += new System.EventHandler(this.aaplOrderToolStripMenuItem_Click);
            // 
            // fbOrderToolStripMenuItem
            // 
            this.fbOrderToolStripMenuItem.Name = "fbOrderToolStripMenuItem";
            this.fbOrderToolStripMenuItem.Size = new System.Drawing.Size(426, 46);
            this.fbOrderToolStripMenuItem.Text = "Facebook Inc.";
            this.fbOrderToolStripMenuItem.Click += new System.EventHandler(this.fbOrderToolStripMenuItem_Click);
            // 
            // marketByPriceToolStripMenuItem
            // 
            this.marketByPriceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msftPriceToolStripMenuItem,
            this.aaplPriceToolStripMenuItem,
            this.fbPriceToolStripMenuItem});
            this.marketByPriceToolStripMenuItem.Name = "marketByPriceToolStripMenuItem";
            this.marketByPriceToolStripMenuItem.Size = new System.Drawing.Size(411, 46);
            this.marketByPriceToolStripMenuItem.Text = "Market By Price";
            // 
            // msftPriceToolStripMenuItem
            // 
            this.msftPriceToolStripMenuItem.Name = "msftPriceToolStripMenuItem";
            this.msftPriceToolStripMenuItem.Size = new System.Drawing.Size(426, 46);
            this.msftPriceToolStripMenuItem.Text = "Microsoft Corporation";
            this.msftPriceToolStripMenuItem.Click += new System.EventHandler(this.msftPriceToolStripMenuItem_Click);
            // 
            // aaplPriceToolStripMenuItem
            // 
            this.aaplPriceToolStripMenuItem.Name = "aaplPriceToolStripMenuItem";
            this.aaplPriceToolStripMenuItem.Size = new System.Drawing.Size(426, 46);
            this.aaplPriceToolStripMenuItem.Text = "Apple Inc.";
            this.aaplPriceToolStripMenuItem.Click += new System.EventHandler(this.aaplPriceToolStripMenuItem_Click);
            // 
            // fbPriceToolStripMenuItem
            // 
            this.fbPriceToolStripMenuItem.Name = "fbPriceToolStripMenuItem";
            this.fbPriceToolStripMenuItem.Size = new System.Drawing.Size(426, 46);
            this.fbPriceToolStripMenuItem.Text = "Facebook Inc.";
            this.fbPriceToolStripMenuItem.Click += new System.EventHandler(this.fbPriceToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bidToolStripMenuItem,
            this.askToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(120, 48);
            this.ordersToolStripMenuItem.Text = "Orders";
            this.ordersToolStripMenuItem.Visible = false;
            // 
            // bidToolStripMenuItem
            // 
            this.bidToolStripMenuItem.Name = "bidToolStripMenuItem";
            this.bidToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.bidToolStripMenuItem.Text = "Bid";
            this.bidToolStripMenuItem.Click += new System.EventHandler(this.bidToolStripMenuItem_Click);
            // 
            // askToolStripMenuItem
            // 
            this.askToolStripMenuItem.Name = "askToolStripMenuItem";
            this.askToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.askToolStripMenuItem.Text = "Ask";
            this.askToolStripMenuItem.Click += new System.EventHandler(this.askToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.horizontalTileToolStripMenuItem,
            this.verticalTileToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(153, 48);
            this.windowsToolStripMenuItem.Text = "&Windows";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // horizontalTileToolStripMenuItem
            // 
            this.horizontalTileToolStripMenuItem.Name = "horizontalTileToolStripMenuItem";
            this.horizontalTileToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.horizontalTileToolStripMenuItem.Text = "Horizontal Tile";
            this.horizontalTileToolStripMenuItem.Click += new System.EventHandler(this.horizontalTileToolStripMenuItem_Click);
            // 
            // verticalTileToolStripMenuItem
            // 
            this.verticalTileToolStripMenuItem.Name = "verticalTileToolStripMenuItem";
            this.verticalTileToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.verticalTileToolStripMenuItem.Text = "Vertical Tile";
            this.verticalTileToolStripMenuItem.Click += new System.EventHandler(this.verticalTileToolStripMenuItem_Click);
            // 
            // StockExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2037, 1039);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
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
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalTileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalTileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msftOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aaplOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fbOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msftPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aaplPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fbPriceToolStripMenuItem;
    }
}

