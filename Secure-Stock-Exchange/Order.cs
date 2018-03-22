using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secure_Stock_Exchange
{
    abstract class Order
    {
        public abstract double getPrice();
        public abstract void setPrice(double price);
    }

    class BuyOrder : Order
    {
        public DateTime orderDateTime;
        public int orderSize;
        private double _orderPrice;
        public BuyOrder()
        {

        }
        public override void setPrice(double price)
        {
            this._orderPrice = price;
        }

        public override double getPrice()
        {
            return this._orderPrice;
        }
    }

    class SellOrder : Order
    {
        public DateTime orderDateTime;
        public int orderSize;
        private double _orderPrice;
        public SellOrder()
        {

        }
        public override void setPrice(double price)
        {
            this._orderPrice = price;
        }

        public override double getPrice()
        {
            return this._orderPrice;
        }
    }
}
