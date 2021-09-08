using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Cappuccino : Coffee, IMilk
    {

        public Cappuccino() : base()
        {

        }

        public Cappuccino(int discount) : base(discount)
        {

        }
        public override string coffeeType()
        {
            return "Cappuccino";
        }

        public int mlMilk()
        {
            return 200;
        }

        public override string strength()
        {
            return "weak";
        }

        public override int price()
        {
            return base.price() - base.Discount;
        }


    }
}
