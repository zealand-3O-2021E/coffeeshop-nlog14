using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class BlackCoffee : Coffee, ICoffeeBlend
    {
        public BlackCoffee () : base() 
        { }

        public BlackCoffee(int discount) : base(discount)
        {

        }
        public override string coffeeType()
        {
            return "Black coffee";
        }

        public override int price()
        {
            return base.price() - base.Discount;
        }

        public override string strength()
        {
            return "Strong" ;
        }

        public string CoffeeBlend()
        {
            return "CoffeeBlend";
        }
    }
}
