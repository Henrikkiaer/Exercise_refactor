﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringSample1
{
    ///<inheritdoc/>
    class RegularPrice : Price
    {
        public override double GetCharge(int daysRented)
        {
            double thisAmount = 0;
            thisAmount += 2;
            if (daysRented > 2)
                thisAmount += (daysRented - 2) * 1.5;
            return thisAmount;
        }

        public override int GetPriceCode()
        {
            return Movie.REGULAR;
        }
    }
}
