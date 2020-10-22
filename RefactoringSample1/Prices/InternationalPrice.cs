using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringSample1
{
    /// <inheritdoc/>
    class InternationalPrice : Price
    {
        public override double GetCharge(int daysRented)
        {
           
            return 0;
        }

        public override int GetPriceCode()
        {
            return Movie.INTERNATIONAL;
        }
    }
}
