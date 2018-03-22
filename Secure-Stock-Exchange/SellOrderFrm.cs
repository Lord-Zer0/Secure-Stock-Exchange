using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secure_Stock_Exchange
{
    public partial class SellOrderFrm : Form
    {
        public SellOrderFrm()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string companyName = this.selectShareList.Text;
            int numShares = Convert.ToInt32(this.numSharesTxt.Text);
            double sellPrice = Convert.ToDouble(this.salePriceLbl.Text);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
