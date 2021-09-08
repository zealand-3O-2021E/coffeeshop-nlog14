using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class FlatWhite : Coffee, IMilk
    {
        public FlatWhite() : base ()
        { 
        
        }

        public FlatWhite(int discount) : base(discount)
        { 
        
        }
        public override string coffeeType()
        {
           return "FlatWhite";
        }

        public int mlMilk()
        {
            return 150;
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
