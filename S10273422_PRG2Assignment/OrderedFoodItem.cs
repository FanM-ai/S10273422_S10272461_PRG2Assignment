using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//==========================================================
// Student Number : S10273422H
// Student Name : FanMing
// Partner Name : Droydon Goh
//==========================================================
namespace S10273422_PRG2Assignment
{
	internal class OrderedFoodItem : FoodItem
	{
		private int qty;

		public int Qty
		{
			get { return qty; }
			set { qty = value; }
		}
		private double subTotal;

		public double SubTotal
		{
			get { return subTotal; }
			set { subTotal = value; }
		}
		//Constructor
		public OrderedFoodItem(string itemName, string itemDesc, double itemPrice, string customize, int qty, double subTotal) : base(itemName, itemDesc, itemPrice, customize)
		{
			this.qty = qty;
			this.subTotal = subTotal;
		}
		//method
		public double CalculateSubTotal()
		{
			return subTotal = (Qty * ItemPrice);
		}
		public override string ToString()
		{
			return base.ToString() + " " + Qty + " x " + ItemName + " (" + Customize + ") - $" + SubTotal.ToString("0.00");

		}
	}
}
