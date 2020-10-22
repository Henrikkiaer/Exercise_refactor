using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringSample1
{
    /// <inheritdoc/>
    class NewReleasePrice : Price
    {
        public override double GetCharge(int daysRented)
        {
            double thisAmount = 0;
            thisAmount += daysRented * 3;
            return thisAmount;
        }

        public override int GetPriceCode()
        {
            return Movie.NEW_RELEASE;
        }
    }
}
