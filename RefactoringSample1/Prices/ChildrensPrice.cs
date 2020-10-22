using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringSample1
{
    ///<inheritdoc/>
    public class ChildrensPrice : Price
    {

        public override double GetCharge(int daysRented)
        {
            double thisAmount = 0;
            thisAmount += 1.5;
            if (daysRented > 3)
                thisAmount += (daysRented - 3) * 1.5;
            return thisAmount;
        }

        public override int GetPriceCode()
        {
            return Movie.CHILDRENS;
        }
    }
}
