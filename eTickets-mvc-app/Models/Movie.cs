using System;
using System.ComponentModel.DataAnnotations;
using eTickets_mvc_app.Data;

namespace eTickets_mvc_app.Models
{
	public class Movie
	{
		public Movie()
		{
		}

		[Key]

		public int Id { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public double MyProperty { get; set; }

		public string ImageURL { get; set; }

		public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

		public MovieCategory MovieCategory { get; set; }
    }
}

