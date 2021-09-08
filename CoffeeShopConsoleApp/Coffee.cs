using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    /// <summary>
    /// A class that is used for coffe orders
    /// </summary>
    public abstract class Coffee
    {
        public Coffee()
        {
            Discount = 0;

        }

        public Coffee(int discount)
        {
            if (discount > 5)
                throw new ArgumentException("Discount cannot be greater than 5kr.");
            if (discount < 0)
                throw new ArgumentException("Discount must be between 1 and 5");
           
            discount = Discount;
        }

        public int Discount { get; private set; }
       
        /// <summary>
        /// returns the price of the coffee
        /// It's possible to override this method, beacuse it is virtual 
        /// </summary>
        /// <returns>20 dkr</returns>
        public virtual int price()
        {
            return 20 - Discount;
        }
        public abstract string strength();

        public abstract string coffeeType();

        public override string ToString()
        {
            return $"Coffee type: {coffeeType()}, Coffee strength: {strength()}, Coffee price: {price()}";

        }

    }
}
