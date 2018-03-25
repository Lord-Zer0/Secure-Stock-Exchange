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
    public partial class BuyOrderFrm : Form
    {
        private List<Company> _stocks;
        public BuyOrderFrm(List<Company> m)
        {
            InitializeComponent();
            this._stocks = m;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Fetch form data
                string companyName = this.selectShareList.Text;
                int numShares = Convert.ToInt32(this.numSharesTxt.Text);
                double buyPrice = Convert.ToDouble(this.buyPriceTxt.Text);
                //Create new buy Order
                BuyOrder buy = new BuyOrder(numShares, buyPrice);
                //Register buy order
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
