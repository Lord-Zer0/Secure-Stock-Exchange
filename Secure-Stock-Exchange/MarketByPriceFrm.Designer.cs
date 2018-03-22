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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarketByPriceFrm));
            this.PriceDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PriceDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PriceDataGrid
            // 
            this.PriceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PriceDataGrid.Location = new System.Drawing.Point(11, 12);
            this.PriceDataGrid.Name = "PriceDataGrid";
            this.PriceDataGrid.RowTemplate.Height = 40;
            this.PriceDataGrid.Size = new System.Drawing.Size(905, 827);
            this.PriceDataGrid.TabIndex = 0;
            // 
            // MarketByPriceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 851);
            this.Controls.Add(this.PriceDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MarketByPriceFrm";
            this.Text = "Market Depth By Price:";
            ((System.ComponentModel.ISupportInitialize)(this.PriceDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PriceDataGrid;
    }
}