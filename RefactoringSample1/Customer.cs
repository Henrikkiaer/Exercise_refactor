using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringSample1
{
	/// <summary>
	/// The main customer class.
	/// Contains all methods related to the customers actions
	/// </summary>
	public class Customer
	{
		private string _name;
		private List<Rental> _rentals = new List<Rental>();
		public Customer(string name)
		{
			_name = name;
		}

		/// <summary>
		/// Function to add a rental object to the customers list of rentals.
		/// </summary>
		/// <param name="rent">Rental A rent object</param>
		public void AddRental(Rental rent)
		{
			_rentals.Add(rent);
		}

		/// <summary>
		/// Function to get the name of a Customer.
		/// </summary>
		/// <returns>
		/// string The name of the customer
		/// </returns>
		public string GetName()
		{
			return _name;
		}

		/// <summary>
		/// Function to get the total charge from a list of rentals.
		/// </summary>
		/// <remarks>
		/// Will loop over a list of rentals, while calling the rentals internal charge calculating function.
		/// </remarks>
		/// <returns>
		/// double The total charge from a set of rentals.
		/// </returns>
		public double GetTotalCharge()
		{
			double result = 0;

			foreach (Rental rental in _rentals)
			{
				result += Rental.GetCharge(rental);
			}

			return result;
		}

		/// <summary>
		/// Function to get the total amount of frequency points from a list of rentals.
		/// </summary>
		/// <remarks>
		/// Will loop over a list of rentals, while calling the rentals internal frequency point calculating function.
		/// </remarks>
		/// <returns>
		/// int The total amount of frequency points from a set of rentals.
		/// </returns>
		public int GetFrequentPoints()
		{
			int result = 0;

			foreach (Rental rental in _rentals)
			{
				result += Rental.GetFrequentPoints(rental);
			}

			return result;
		}

		/// <summary>
		/// Method for generating a string response to the customer from the film rental service.
		/// </summary>
		/// <returns>
		/// string  Returns a string response with the amount owned to the store, and the frequency points earned.
		/// </returns>
		public string Statement()
		{
			var result = $"Rental Record for {GetName()}\n";

			foreach (Rental rental in _rentals) 
			{ 
				//show figures for this rental
				result += $"\t{rental.GetMovie().GetTitle()}\t{Rental.GetCharge(rental)}\n";
            }

            //add footer lines
            result += $"Amount owed is {GetTotalCharge()}\n";
			result += $"You earned {GetFrequentPoints()} frequent renter points";
			return result;
		}

		/// <summary>
		/// Method for generating a HTML response to the customer from the film rental service.
		/// </summary>
		/// <returns>
		/// string Returns a string-HTML response with the amount owned to the store, and the frequency points earned.
		/// </returns>
		public string HtmlStatement()
		{
			var result = $"<h1>Rental Record for {GetName()}</h1>";

			foreach (Rental rental in _rentals)
			{
				//show figures for this rental
				result += $"<p>{rental.GetMovie().GetTitle()}\t{Rental.GetCharge(rental)}</p>";
			}

			//add footer lines
			result += $"<p>Amount owed is {GetTotalCharge()}</p>";
			result += $"<p>ou earned {GetFrequentPoints()} frequent renter points</p>";
			return result;
		}
	}
}
