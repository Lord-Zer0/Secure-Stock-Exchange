namespace Secure_Stock_Exchange
{
    partial class SellOrderFrm
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
            this.selectShareLbl = new System.Windows.Forms.Label();
            this.numSharesLbl = new System.Windows.Forms.Label();
            this.salePriceLbl = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numSharesTxt = new System.Windows.Forms.MaskedTextBox();
            this.salePriceTxt = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // selectShareLbl
            // 
            this.selectShareLbl.AutoSize = true;
            this.selectShareLbl.Location = new System.Drawing.Point(40, 67);
            this.selectShareLbl.Name = "selectShareLbl";
            this.selectShareLbl.Size = new System.Drawing.Size(265, 32);
            this.selectShareLbl.TabIndex = 0;
            this.selectShareLbl.Text = "Select Share to Sell";
            // 
            // numSharesLbl
            // 
            this.numSharesLbl.AutoSize = true;
            this.numSharesLbl.Location = new System.Drawing.Point(62, 201);
            this.numSharesLbl.Name = "numSharesLbl";
            this.numSharesLbl.Size = new System.Drawing.Size(243, 32);
            this.numSharesLbl.TabIndex = 1;
            this.numSharesLbl.Text = "Number of Shares";
            // 
            // salePriceLbl
            // 
            this.salePriceLbl.AutoSize = true;
            this.salePriceLbl.Location = new System.Drawing.Point(160, 290);
            this.salePriceLbl.Name = "salePriceLbl";
            this.salePriceLbl.Size = new System.Drawing.Size(145, 32);
            this.salePriceLbl.TabIndex = 2;
            this.salePriceLbl.Text = "Sale Price";
            // 
            // submitBtn
            // 
            this.submitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.submitBtn.Location = new System.Drawing.Point(180, 397);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(160, 47);
            this.submitBtn.TabIndex = 3;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(426, 397);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(160, 47);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Microsoft Corporation",
            "Apple Inc.",
            "Facebook Inc."});
            this.comboBox1.Location = new System.Drawing.Point(330, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(403, 39);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "Microsoft Corporation";
            // 
            // numSharesTxt
            // 
            this.numSharesTxt.Location = new System.Drawing.Point(330, 195);
            this.numSharesTxt.Mask = "999999";
            this.numSharesTxt.Name = "numSharesTxt";
            this.numSharesTxt.Size = new System.Drawing.Size(190, 38);
            this.numSharesTxt.TabIndex = 8;
            this.numSharesTxt.ValidatingType = typeof(int);
            // 
            // salePriceTxt
            // 
            this.salePriceTxt.Location = new System.Drawing.Point(330, 284);
            this.salePriceTxt.Mask = "999999.00";
            this.salePriceTxt.Name = "salePriceTxt";
            this.salePriceTxt.Size = new System.Drawing.Size(190, 38);
            this.salePriceTxt.TabIndex = 9;
            this.salePriceTxt.ValidatingType = typeof(int);
            // 
            // SellOrderFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 532);
            this.ControlBox = false;
            this.Controls.Add(this.salePriceTxt);
            this.Controls.Add(this.numSharesTxt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.salePriceLbl);
            this.Controls.Add(this.numSharesLbl);
            this.Controls.Add(this.selectShareLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SellOrderFrm";
            this.Text = "Place Sell Order Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectShareLbl;
        private System.Windows.Forms.Label numSharesLbl;
        private System.Windows.Forms.Label salePriceLbl;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox numSharesTxt;
        private System.Windows.Forms.MaskedTextBox salePriceTxt;
    }
}