namespace Secure_Stock_Exchange
{
    partial class BuyOrderFrm
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
            this.selectShareList = new System.Windows.Forms.ComboBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.buyPriceLbl = new System.Windows.Forms.Label();
            this.numSharesLbl = new System.Windows.Forms.Label();
            this.selectShareLbl = new System.Windows.Forms.Label();
            this.buyPriceTxt = new System.Windows.Forms.MaskedTextBox();
            this.numSharesTxt = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // selectShareList
            // 
            this.selectShareList.FormattingEnabled = true;
            this.selectShareList.Items.AddRange(new object[] {
            "Microsoft Corporation",
            "Apple Inc.",
            "Facebook Inc."});
            this.selectShareList.Location = new System.Drawing.Point(331, 67);
            this.selectShareList.Name = "selectShareList";
            this.selectShareList.Size = new System.Drawing.Size(403, 39);
            this.selectShareList.TabIndex = 15;
            this.selectShareList.Text = "Microsoft Corporation";
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(428, 397);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(160, 47);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.submitBtn.Location = new System.Drawing.Point(181, 397);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(160, 47);
            this.submitBtn.TabIndex = 11;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // buyPriceLbl
            // 
            this.buyPriceLbl.AutoSize = true;
            this.buyPriceLbl.Location = new System.Drawing.Point(170, 290);
            this.buyPriceLbl.Name = "buyPriceLbl";
            this.buyPriceLbl.Size = new System.Drawing.Size(136, 32);
            this.buyPriceLbl.TabIndex = 10;
            this.buyPriceLbl.Text = "Buy Price";
            // 
            // numSharesLbl
            // 
            this.numSharesLbl.AutoSize = true;
            this.numSharesLbl.Location = new System.Drawing.Point(63, 201);
            this.numSharesLbl.Name = "numSharesLbl";
            this.numSharesLbl.Size = new System.Drawing.Size(243, 32);
            this.numSharesLbl.TabIndex = 9;
            this.numSharesLbl.Text = "Number of Shares";
            // 
            // selectShareLbl
            // 
            this.selectShareLbl.AutoSize = true;
            this.selectShareLbl.Location = new System.Drawing.Point(41, 70);
            this.selectShareLbl.Name = "selectShareLbl";
            this.selectShareLbl.Size = new System.Drawing.Size(265, 32);
            this.selectShareLbl.TabIndex = 8;
            this.selectShareLbl.Text = "Select Share to Buy";
            // 
            // buyPriceTxt
            // 
            this.buyPriceTxt.Location = new System.Drawing.Point(324, 292);
            this.buyPriceTxt.Mask = "999999.00";
            this.buyPriceTxt.Name = "buyPriceTxt";
            this.buyPriceTxt.Size = new System.Drawing.Size(190, 38);
            this.buyPriceTxt.TabIndex = 17;
            this.buyPriceTxt.ValidatingType = typeof(int);
            // 
            // numSharesTxt
            // 
            this.numSharesTxt.Location = new System.Drawing.Point(324, 203);
            this.numSharesTxt.Mask = "999999";
            this.numSharesTxt.Name = "numSharesTxt";
            this.numSharesTxt.Size = new System.Drawing.Size(190, 38);
            this.numSharesTxt.TabIndex = 16;
            this.numSharesTxt.ValidatingType = typeof(int);
            // 
            // BuyOrderFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 532);
            this.ControlBox = false;
            this.Controls.Add(this.buyPriceTxt);
            this.Controls.Add(this.numSharesTxt);
            this.Controls.Add(this.selectShareList);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.buyPriceLbl);
            this.Controls.Add(this.numSharesLbl);
            this.Controls.Add(this.selectShareLbl);
            this.Name = "BuyOrderFrm";
            this.Text = "Place Buy Order Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectShareList;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label buyPriceLbl;
        private System.Windows.Forms.Label numSharesLbl;
        private System.Windows.Forms.Label selectShareLbl;
        private System.Windows.Forms.MaskedTextBox buyPriceTxt;
        private System.Windows.Forms.MaskedTextBox numSharesTxt;
    }
}