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
        private List<Company> _stocks;
        public SellOrderFrm(List<Company> m)
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
                double sellPrice = Convert.ToDouble(this.salePriceTxt.Text);
                //Create new sell Order
                SellOrder sell = new SellOrder(numShares, sellPrice);
                //Register sell order
                
            } catch(Exception ex)
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
