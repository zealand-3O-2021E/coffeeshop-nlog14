using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Cortado : Coffee, IMilk
    {
        public Cortado() : base()
        { }

        public Cortado(int discount) : base(discount)
        {

        }

        public override string coffeeType()
        {
            return "Cortado";
        }

        public int mlMilk()
        {
            return 40;
        }

        public override int price()
        {
            return 25 - base.Discount;
        }

        public override string strength()
        {
            return "Medium";
        }
    }
}
