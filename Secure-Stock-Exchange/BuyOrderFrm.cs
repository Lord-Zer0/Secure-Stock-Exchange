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
        private BuyOrder _bo;
        public BuyOrderFrm()
        {
            InitializeComponent();
            this._bo = new BuyOrder();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
