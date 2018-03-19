namespace Secure_Stock_Exchange
{
    partial class StockStateSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockStateSummary));
            this.StateSummaryDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StateSummaryDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // StateSummaryDataGrid
            // 
            this.StateSummaryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StateSummaryDataGrid.Location = new System.Drawing.Point(12, 12);
            this.StateSummaryDataGrid.Name = "StateSummaryDataGrid";
            this.StateSummaryDataGrid.ReadOnly = true;
            this.StateSummaryDataGrid.RowTemplate.Height = 40;
            this.StateSummaryDataGrid.Size = new System.Drawing.Size(1704, 546);
            this.StateSummaryDataGrid.TabIndex = 0;
            // 
            // StockStateSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1728, 570);
            this.Controls.Add(this.StateSummaryDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockStateSummary";
            this.Text = "Stock State Summary";
            ((System.ComponentModel.ISupportInitialize)(this.StateSummaryDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StateSummaryDataGrid;
    }
}