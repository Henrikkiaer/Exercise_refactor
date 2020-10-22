using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RefactoringSample1.Tests
{
    /// <summary>
    /// Class containing the methods to perform unit tests on the Customer class
    /// </summary>
    public class CustomerTest
    {

        /// <summary>
        /// List of Movie object to use for unit tests.
        /// </summary>
        private static List<Movie> _movies = new List<Movie>
            {
                new Movie("The Lion King", Movie.CHILDRENS),
                new Movie("Joker", Movie.NEW_RELEASE),
                new Movie("Avengers: Endgame", Movie.REGULAR)
            };

        /// <summary>
        /// Test data to use for unit tests of frequency points.
        /// </summary>
        /// <returns> Returns a TheoryData<Rental, Rental, double, int> list object. </returns>
        /// <remarks>
        /// The double represents the charge.
        /// the int represents the frequenc
        /// </remarks>
        public static TheoryData<Rental, Rental, double, int> FrequentPointsTestData() // legg til en ny rental i TheoryData<Rental, Rental, int>
        {
            return new TheoryData<Rental, Rental, double, int> {
                { new Rental(_movies[0], 4), new Rental(_movies[1], 2), 9, 3 },
                { new Rental(_movies[2], 2), new Rental(_movies[0], 3), 3.5, 2 },
                { new Rental(_movies[1], 2), new Rental(_movies[2], 3), 9.5, 3 },
                { new Rental(_movies[1], 4), new Rental(_movies[1], 3), 21, 4 }
            };
        }

        /// <summary>
        /// Nethod for unit testing the calculation of frequency points.
        /// </summary>
        /// <param name="rental1"> Rental first rental to be added to the customers _rental list</param>
        /// <param name="rental2"> Rental second rental to be added to the customers _rental list</param>
        /// <param name="totalCharge">double The expted amount of charge for the rental of the two movies. </param>
        /// <param name="totalFreqPoints">int The expected amount of frequency points from the rental. </param>
        [Theory]
        [MemberData(nameof(FrequentPointsTestData))]
        public void GetTotalChargeTest(Rental rental1, Rental rental2, double totalCharge, int totalFreqPoints)
        {
            // Ta inn to rentals og legg dem til, for så å sammenligne
            var customer = new Customer("Henrik");
            customer.AddRental(rental1);
            customer.AddRental(rental2);
            
            var statement = customer.Statement();
            var htmlStatement = customer.HtmlStatement();
            var customerTotalCharge = customer.GetTotalCharge();
            var customerTotalFreqPoints = customer.GetFrequentPoints();

            Assert.Equal(customerTotalCharge, totalCharge);
            Assert.Equal(customerTotalFreqPoints, totalFreqPoints);
        }





    }
=======
using Xunit;
using System.Collections.Generic;

namespace RefactoringSample1.Tests
{
	public class CustomerTest
	{
		private static List<Movie> _movies = new List<Movie>
			{
				new Movie("The Lion King", Movie.CHILDRENS),
				new Movie("Joker", Movie.NEW_RELEASE),
				new Movie("Avengers: Endgame", Movie.REGULAR)
			};

		// Strongly typed test with memberdata
		[Theory]
		[MemberData(nameof(RentalTestData))]
		public void CanCreateStatement(Rental rental1, Rental rental2, double totalAmt, int freqPoints)
		{
			var customer = new Customer("Jane Doe");
			customer.AddRental(rental1);
			customer.AddRental(rental2);
			var statement = customer.Statement();
			var totalAmount = customer.GetTotalCharge();
			var frequentRenterPoints = customer.GetFrequentPoints();

			Assert.Equal(totalAmount, totalAmt);
			Assert.Equal(frequentRenterPoints, freqPoints);
		}

		// Method to return rental data that is strongly typed while you add testdata
		public static TheoryData<Rental, Rental, double, int> RentalTestData()
		{
			return new TheoryData<Rental, Rental, double, int> {
				{ new Rental(_movies[0], 4), new Rental(_movies[1], 2), 9, 3 },
				{ new Rental(_movies[2], 2), new Rental(_movies[0], 3), 3.5, 2 },
				{ new Rental(_movies[1], 2), new Rental(_movies[2], 3), 9.5, 3 },
				{ new Rental(_movies[1], 4), new Rental(_movies[1], 3), 21, 4 }
			};
		}
	}
>>>>>>> c5deef57b0faa8dd634563571067e281e4df2fdf
}
