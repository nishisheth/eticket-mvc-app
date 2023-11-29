using System;
using System.ComponentModel.DataAnnotations;

namespace eTickets_mvc_app.Models
{
	public class Actor
	{
		[Key]

		public int Id { get; set; }

        public string ProfilePictureURL { get; set; }

        public string FullName { get; set; }

		public string Bio { get; set; }
	}
}

