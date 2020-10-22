using System;
using Xunit;
using System.Collections.Generic;

namespace RefactoringSample1.Tests
{
    /// <summary>
    /// Class containing the unit test for the Rental class.
    /// </summary>
    public class RentalTest
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
        /// Unit test for the calculation of earning frequency points.
        /// </summary>
        /// <param name="rental">Rental object to use for calcuations</param>
        /// <param name="points">int points to check for expected behaviour</param>
        [Theory]
        [MemberData(nameof(FrequentPointsTestData))]
        public void GetFrequentPoints(Rental rental, int points)
        {
            Assert.Equal(Rental.GetFrequentPoints(rental), points);
        }

        /// <summary>
        /// Unit test for the calculation of charge for the rental.
        /// </summary>
        /// <param name="rental">Rental object to use for calcuations</param>
        /// <param name="points">double points to check for expected behaviour</param>
        [Theory]
        [MemberData(nameof(GetChargeRentalTestData))]
        public void GetCharge(Rental rental, double charge)
        {
            Assert.Equal(Rental.GetCharge(rental), charge);
        }

        /// <summary>
        /// Test data to use for unit tests of frequency points.
        /// </summary>
        /// <returns> Returns a TheoryData<Rental, int> list object </returns>
        public static TheoryData<Rental, int> FrequentPointsTestData()
        {
            return new TheoryData<Rental, int>
            {
                { new Rental(_movies[0],1),1 },
                { new Rental(_movies[0],2),1 },
                { new Rental(_movies[0],3),1 },
                { new Rental(_movies[1],1),1 },
                { new Rental(_movies[1],2),2 },
                { new Rental(_movies[1],3),2 }
            };
        }

        /// <summary>
        /// Test data to use for unit tests of calculating charge.
        /// </summary>
        /// <returns> Returns a TheoryData<Rental, int> list object </returns>
        public static TheoryData<Rental, double> GetChargeRentalTestData()
        {
            return new TheoryData<Rental, double>
            {
                { new Rental(_movies[2], 1),2 },
                { new Rental(_movies[2], 2),2 },
                { new Rental(_movies[2], 3),3.5 },
                { new Rental(_movies[2], 4),5 },
                { new Rental(_movies[0], 3),1.5 },
                { new Rental(_movies[0], 4),3 },
                { new Rental(_movies[1], 2),6 },
                { new Rental(_movies[1], 3),9 },
            };
        }
    }
}
