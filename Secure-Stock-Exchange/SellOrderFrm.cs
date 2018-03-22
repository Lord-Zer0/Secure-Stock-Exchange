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
        private SellOrder _so;
        public SellOrderFrm()
        {
            InitializeComponent();
            this._so = new SellOrder();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
