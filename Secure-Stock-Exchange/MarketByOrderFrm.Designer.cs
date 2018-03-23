namespace Secure_Stock_Exchange
{
    partial class MarketByOrderFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarketByOrderFrm));
            this.OrderDataGrid = new System.Windows.Forms.DataGridView();
            this.marketByOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SellLabel = new System.Windows.Forms.Label();
            this.buyLabel = new System.Windows.Forms.Label();
            this.buyVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketByOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderDataGrid
            // 
            this.OrderDataGrid.AutoGenerateColumns = false;
            this.OrderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buyVolume,
            this.buyPrice,
            this.sellPrice,
            this.sellVolume});
            this.OrderDataGrid.DataSource = this.marketByOrderBindingSource;
            this.OrderDataGrid.Location = new System.Drawing.Point(12, 71);
            this.OrderDataGrid.Name = "OrderDataGrid";
            this.OrderDataGrid.RowTemplate.Height = 40;
            this.OrderDataGrid.Size = new System.Drawing.Size(903, 781);
            this.OrderDataGrid.TabIndex = 0;
            // 
            // marketByOrderBindingSource
            // 
            this.marketByOrderBindingSource.DataSource = typeof(Secure_Stock_Exchange.MarketByOrder);
            // 
            // SellLabel
            // 
            this.SellLabel.AutoSize = true;
            this.SellLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.SellLabel.Location = new System.Drawing.Point(604, 22);
            this.SellLabel.Name = "SellLabel";
            this.SellLabel.Size = new System.Drawing.Size(64, 32);
            this.SellLabel.TabIndex = 4;
            this.SellLabel.Text = "Sell";
            // 
            // buyLabel
            // 
            this.buyLabel.AutoSize = true;
            this.buyLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.buyLabel.Location = new System.Drawing.Point(244, 22);
            this.buyLabel.Name = "buyLabel";
            this.buyLabel.Size = new System.Drawing.Size(64, 32);
            this.buyLabel.TabIndex = 3;
            this.buyLabel.Text = "Buy";
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
            // MarketByOrderFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 864);
            this.Controls.Add(this.SellLabel);
            this.Controls.Add(this.buyLabel);
            this.Controls.Add(this.OrderDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MarketByOrderFrm";
            this.Text = "Market Depth By Order: ";
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketByOrderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OrderDataGrid;
        private System.Windows.Forms.BindingSource marketByOrderBindingSource;
        private System.Windows.Forms.Label SellLabel;
        private System.Windows.Forms.Label buyLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellVolume;
    }
}