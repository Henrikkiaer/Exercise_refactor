using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringSample1
{
	/// <summary>
	/// Main class for a rental, contains all methods needed to calculate charge and amount  of frequency points.
	/// </summary>
	public class Rental
	{
		/// <value>Movie The _movie value is the movie that has been rented </value>
		private Movie _movie;

		/// <value> int The _daysRented value represents in int the amount of days _movie has been rented. </value>
		private int _daysRented;


		/// <summary>
		/// Constructor for the Rental class
		/// </summary>
		/// <param name="movie">Movie object for the rental.</param>
		/// <param name="daysRented">int Amount of days the movie is to be rented. </param>
		public Rental(Movie movie, int daysRented)
		{
			_movie = movie;
			_daysRented = daysRented;
		}

		/// <summary>
		/// Method for returning 
		/// </summary>
		/// <returns>int Number of days for the rental</returns>
		public int GetDaysRented()
		{
			return _daysRented;
		}

		/// <summary>
		/// Method for returning the movie in a rental.
		/// </summary>
		/// <returns>Movie The movie in the rental</returns>
		public Movie GetMovie()
		{
			return _movie;
		}

		/// <summary>
		/// Method for calculating the cost of the rental
		/// </summary>
		/// <param name="rental">The rental object</param>
		/// <returns>double The cost of renting said movie. </returns>
        public static double GetCharge(Rental rental)
        {
            return rental._movie._price.GetCharge(rental._daysRented);
        }

		/// <summary>
		/// Method for calculating the amount of frequency points that have been earned through the rental.
		/// </summary>
		/// <param name="rental"> Rental onject to use for calculations. </param>
		/// <returns>int  Amount of frequency points earned. </returns>
        public static int GetFrequentPoints(Rental rental)
        {
            // add frequent renter points
            var frequentRenterPoints=1;
            // add bonus for a two day new release rental
            if ((rental.GetMovie().GetPriceCode() == Movie.NEW_RELEASE) && rental.GetDaysRented() > 1)
                frequentRenterPoints++;
            return frequentRenterPoints;
        }
    }
}
