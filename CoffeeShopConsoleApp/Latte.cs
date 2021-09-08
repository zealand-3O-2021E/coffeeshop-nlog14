using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Latte : Coffee, IMilk
    {
        public Latte () : base()
        { }

        public Latte(int discount) : base (discount)
        {

        }
        
        public override string coffeeType()
        {
           return "Latte";
        }

        public int mlMilk()
        {
            return 200;
        }

        public override int price()
        {
            return 40 - base.Discount;
        }

        public override string strength()
        {
            return "Weak";
        }
    }
}
