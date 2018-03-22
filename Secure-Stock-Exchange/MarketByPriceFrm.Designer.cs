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
            this.PriceDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PriceDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PriceDataGrid
            // 
            this.PriceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PriceDataGrid.Location = new System.Drawing.Point(21, 23);
            this.PriceDataGrid.Name = "PriceDataGrid";
            this.PriceDataGrid.RowTemplate.Height = 40;
            this.PriceDataGrid.Size = new System.Drawing.Size(896, 816);
            this.PriceDataGrid.TabIndex = 0;
            // 
            // MarketByPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 865);
            this.Controls.Add(this.PriceDataGrid);
            this.Name = "MarketByPrice";
            this.Text = "Market Depth By Price (<<COMPANY>>)";
            ((System.ComponentModel.ISupportInitialize)(this.PriceDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PriceDataGrid;
    }
}