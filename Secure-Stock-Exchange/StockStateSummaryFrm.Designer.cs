namespace Secure_Stock_Exchange
{
    partial class StockStateSummaryFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockStateSummaryFrm));
            this.StateSummaryDataGrid = new System.Windows.Forms.DataGridView();
            this.stockStateSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companySymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeSymbol = new System.Windows.Forms.DataGridViewImageColumn();
            this.changePercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shareVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StateSummaryDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockStateSummaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StateSummaryDataGrid
            // 
            this.StateSummaryDataGrid.AutoGenerateColumns = false;
            this.StateSummaryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StateSummaryDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyName,
            this.companySymbol,
            this.openPrice,
            this.lastSale,
            this.netChange,
            this.changeSymbol,
            this.changePercent,
            this.shareVolume});
            this.StateSummaryDataGrid.DataSource = this.stockStateSummaryBindingSource;
            this.StateSummaryDataGrid.Location = new System.Drawing.Point(12, 12);
            this.StateSummaryDataGrid.Name = "StateSummaryDataGrid";
            this.StateSummaryDataGrid.ReadOnly = true;
            this.StateSummaryDataGrid.RowTemplate.Height = 40;
            this.StateSummaryDataGrid.Size = new System.Drawing.Size(1704, 546);
            this.StateSummaryDataGrid.TabIndex = 0;
            // 
            // stockStateSummaryBindingSource
            // 
            this.stockStateSummaryBindingSource.DataSource = typeof(Secure_Stock_Exchange.StockStateSummary);
            // 
            // companyName
            // 
            this.companyName.HeaderText = "company";
            this.companyName.Name = "companyName";
            this.companyName.ReadOnly = true;
            // 
            // companySymbol
            // 
            this.companySymbol.HeaderText = "Symbol";
            this.companySymbol.Name = "companySymbol";
            this.companySymbol.ReadOnly = true;
            // 
            // openPrice
            // 
            this.openPrice.HeaderText = "Open Price";
            this.openPrice.Name = "openPrice";
            this.openPrice.ReadOnly = true;
            // 
            // lastSale
            // 
            this.lastSale.HeaderText = "Last Sale";
            this.lastSale.Name = "lastSale";
            this.lastSale.ReadOnly = true;
            // 
            // netChange
            // 
            this.netChange.HeaderText = "Change Net";
            this.netChange.Name = "netChange";
            this.netChange.ReadOnly = true;
            // 
            // changeSymbol
            // 
            this.changeSymbol.HeaderText = "";
            this.changeSymbol.Image = global::Secure_Stock_Exchange.Properties.Resources.noChange;
            this.changeSymbol.Name = "changeSymbol";
            this.changeSymbol.ReadOnly = true;
            // 
            // changePercent
            // 
            this.changePercent.HeaderText = "Change %";
            this.changePercent.Name = "changePercent";
            this.changePercent.ReadOnly = true;
            // 
            // shareVolume
            // 
            this.shareVolume.HeaderText = "Share Volume";
            this.shareVolume.Name = "shareVolume";
            this.shareVolume.ReadOnly = true;
            // 
            // StockStateSummaryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1728, 570);
            this.Controls.Add(this.StateSummaryDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockStateSummaryFrm";
            this.Text = "Stock State Summary";
            ((System.ComponentModel.ISupportInitialize)(this.StateSummaryDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockStateSummaryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StateSummaryDataGrid;
        private System.Windows.Forms.BindingSource stockStateSummaryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn companySymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn openPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn netChange;
        private System.Windows.Forms.DataGridViewImageColumn changeSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn changePercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn shareVolume;
    }
}