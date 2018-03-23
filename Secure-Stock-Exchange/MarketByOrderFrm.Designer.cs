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
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketByOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderDataGrid
            // 
            this.OrderDataGrid.AutoGenerateColumns = false;
            this.OrderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDataGrid.DataSource = this.marketByOrderBindingSource;
            this.OrderDataGrid.Location = new System.Drawing.Point(12, 12);
            this.OrderDataGrid.Name = "OrderDataGrid";
            this.OrderDataGrid.RowTemplate.Height = 40;
            this.OrderDataGrid.Size = new System.Drawing.Size(903, 840);
            this.OrderDataGrid.TabIndex = 0;
            // 
            // marketByOrderBindingSource
            // 
            this.marketByOrderBindingSource.DataSource = typeof(Secure_Stock_Exchange.MarketByOrder);
            // 
            // MarketByOrderFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 864);
            this.Controls.Add(this.OrderDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MarketByOrderFrm";
            this.Text = "Market Depth By Order: ";
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketByOrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OrderDataGrid;
        private System.Windows.Forms.BindingSource marketByOrderBindingSource;
    }
}