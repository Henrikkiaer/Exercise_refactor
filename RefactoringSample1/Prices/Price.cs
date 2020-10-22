using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringSample1
{

    /// <summary>
    /// Class for the prices of a movie.
    /// Contains all methods for calculating charge and amount of frequency points accumulated
    /// </summary>
    public abstract class Price // Vet ikke om denne bør være public eller ikke
    {
        /// <summary>
        /// Collects the price code for a given movie type.
        /// </summary>
        /// <returns>int of price code.</returns>
        abstract public int GetPriceCode();

        /// <summary>
        /// Method for calculating the charge of a rented movie.
        /// </summary>
        /// <param name="daysRented"> How many days the movie has been rented, int. </param>
        /// <returns> The double precision value of the charge for the rental. </returns>
        abstract public double GetCharge(int daysRented);

        /// <summary>
        /// Method for returning the amount of frequency point a customer has earned through the rental.
        /// </summary>
        /// <param name="daysRented"> int How many days the movie has been rented for. </param>
        /// <returns></returns>
        public virtual int GetFrequencyPoints(int daysRented)
        {
            return 1;
        }

    }

}
