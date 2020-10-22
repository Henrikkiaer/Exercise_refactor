using System;

namespace RefactoringSample1
{
	/// <summary>
	/// Main Movie class
	/// </summary>
	public class Movie
	{
		///<value> int Pricode for Childrens films. </value>
		public const int CHILDRENS = 2;
		///<value> int Pricode for regular films. </value>
		public const int REGULAR = 0;
		///<value> int Pricode for newly released films. </value>
		public const int NEW_RELEASE = 1;
		///<value> int Pricode for International films. </value>
		public const int INTERNATIONAL = 3;
		///<value> string Pricode for title of movie </value>
		private string _title;
		///<value> Price model for the movie. </value>
		public Price _price;

		/// <summary>
		/// Constructor for the Movie class
		/// </summary>
		/// <param name="title">string with the title of the movie</param>
		/// <param name="priceCode"> int of price code of the film which sets the _price object of the class</param>
		public Movie(string title, int priceCode)
		{
			_title = title;
			SetPriceCode(priceCode);
		}

		/// <summary>
		/// Get the price code of the movie.
		/// </summary>
		/// <returns> int Price code for the movie. </returns>
		public int GetPriceCode()
		{
			return _price.GetPriceCode();
		}

		/// <summary>
		/// Sets the price code of the film as the correct Price class
		/// </summary>
		/// <param name="PriceCode">Price object corresponsing the type of movie. </param>
		public void SetPriceCode(int PriceCode)
		{
			_price = PriceCode switch
			{
				CHILDRENS => new ChildrensPrice(),
				NEW_RELEASE => new NewReleasePrice(),
				INTERNATIONAL => new InternationalPrice(),
				_ => new RegularPrice()
			};
		}

		/// <summary>
		/// Returns the title of the movie
		/// </summary>
		/// <returns> string Title of the movie. </returns>
		public string GetTitle()
		{
			return _title;
		}
	}
}
