using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secure_Stock_Exchange
{
    public abstract class Order
    {
        public abstract double getPrice();
        public abstract void setPrice(double price);
    }

    public class BuyOrder : Order
    {
        public DateTime orderDateTime;
        public int orderSize;
        private double _orderPrice;
        public BuyOrder(int s, double p)
        {
            this.orderDateTime = DateTime.Now;
            this.orderSize = s;
            this._orderPrice = p;
        }
        public override void setPrice(double price)
        {
            this._orderPrice = price;
        }

        public override double getPrice()
        {
            return this._orderPrice;
        }
        public int Register(Company c)
        {
            c.orders.Add(this);
            return 0;
        }
    }

    public class SellOrder : Order
    {
        public DateTime orderDateTime;
        public int orderSize;
        private double _orderPrice;
        public SellOrder(int s, double p)
        {
            this.orderDateTime = DateTime.Now;
            this.orderSize = s;
            this._orderPrice = p;
        }
        public override void setPrice(double price)
        {
            this._orderPrice = price;
        }

        public override double getPrice()
        {
            return this._orderPrice;
        }
        public int Register(Company c)
        {
            c.orders.Add(this);
            return 0;
        }
    }
}
