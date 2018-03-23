namespace Secure_Stock_Exchange
{
    partial class MarketByPriceFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarketByPriceFrm));
            this.PriceDataGrid = new System.Windows.Forms.DataGridView();
            this.marketByOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marketByPriceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buyLabel = new System.Windows.Forms.Label();
            this.SellLabel = new System.Windows.Forms.Label();
            this.buyNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PriceDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketByOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketByPriceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PriceDataGrid
            // 
            this.PriceDataGrid.AutoGenerateColumns = false;
            this.PriceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PriceDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buyNumber,
            this.buyVolume,
            this.buyPrice,
            this.sellPrice,
            this.sellVolume,
            this.sellNumber});
            this.PriceDataGrid.DataSource = this.marketByOrderBindingSource;
            this.PriceDataGrid.Location = new System.Drawing.Point(11, 67);
            this.PriceDataGrid.Name = "PriceDataGrid";
            this.PriceDataGrid.RowTemplate.Height = 40;
            this.PriceDataGrid.Size = new System.Drawing.Size(905, 772);
            this.PriceDataGrid.TabIndex = 0;
            // 
            // marketByOrderBindingSource
            // 
            this.marketByOrderBindingSource.DataSource = typeof(Secure_Stock_Exchange.MarketByOrder);
            // 
            // marketByPriceBindingSource
            // 
            this.marketByPriceBindingSource.DataSource = typeof(Secure_Stock_Exchange.MarketByPrice);
            // 
            // buyLabel
            // 
            this.buyLabel.AutoSize = true;
            this.buyLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.buyLabel.Location = new System.Drawing.Point(238, 13);
            this.buyLabel.Name = "buyLabel";
            this.buyLabel.Size = new System.Drawing.Size(64, 32);
            this.buyLabel.TabIndex = 1;
            this.buyLabel.Text = "Buy";
            // 
            // SellLabel
            // 
            this.SellLabel.AutoSize = true;
            this.SellLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.SellLabel.Location = new System.Drawing.Point(598, 13);
            this.SellLabel.Name = "SellLabel";
            this.SellLabel.Size = new System.Drawing.Size(64, 32);
            this.SellLabel.TabIndex = 2;
            this.SellLabel.Text = "Sell";
            // 
            // buyNumber
            // 
            this.buyNumber.HeaderText = "#";
            this.buyNumber.Name = "buyNumber";
            this.buyNumber.ReadOnly = true;
            // 
            // buyVolume
            // 
            this.buyVolume.HeaderText = "Volume";
            this.buyVolume.Name = "buyVolume";
            this.buyVolume.ReadOnly = true;
            // 
            // buyPrice
            // 
            this.buyPrice.HeaderText = "Price";
            this.buyPrice.Name = "buyPrice";
            this.buyPrice.ReadOnly = true;
            // 
            // sellPrice
            // 
            this.sellPrice.HeaderText = "Price";
            this.sellPrice.Name = "sellPrice";
            this.sellPrice.ReadOnly = true;
            // 
            // sellVolume
            // 
            this.sellVolume.HeaderText = "Volume";
            this.sellVolume.Name = "sellVolume";
            this.sellVolume.ReadOnly = true;
            // 
            // sellNumber
            // 
            this.sellNumber.HeaderText = "#";
            this.sellNumber.Name = "sellNumber";
            this.sellNumber.ReadOnly = true;
            // 
            // MarketByPriceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 851);
            this.Controls.Add(this.SellLabel);
            this.Controls.Add(this.buyLabel);
            this.Controls.Add(this.PriceDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MarketByPriceFrm";
            this.Text = "Market Depth By Price: ";
            ((System.ComponentModel.ISupportInitialize)(this.PriceDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketByOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketByPriceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PriceDataGrid;
        private System.Windows.Forms.BindingSource marketByPriceBindingSource;
        private System.Windows.Forms.BindingSource marketByOrderBindingSource;
        private System.Windows.Forms.Label buyLabel;
        private System.Windows.Forms.Label SellLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellNumber;
    }
}