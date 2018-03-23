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
            ((System.ComponentModel.ISupportInitialize)(this.PriceDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketByOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketByPriceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PriceDataGrid
            // 
            this.PriceDataGrid.AutoGenerateColumns = false;
            this.PriceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PriceDataGrid.DataSource = this.marketByOrderBindingSource;
            this.PriceDataGrid.Location = new System.Drawing.Point(11, 12);
            this.PriceDataGrid.Name = "PriceDataGrid";
            this.PriceDataGrid.RowTemplate.Height = 40;
            this.PriceDataGrid.Size = new System.Drawing.Size(905, 827);
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
            // MarketByPriceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 851);
            this.Controls.Add(this.PriceDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MarketByPriceFrm";
            this.Text = "Market Depth By Price: ";
            ((System.ComponentModel.ISupportInitialize)(this.PriceDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketByOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketByPriceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PriceDataGrid;
        private System.Windows.Forms.BindingSource marketByPriceBindingSource;
        private System.Windows.Forms.BindingSource marketByOrderBindingSource;
    }
}