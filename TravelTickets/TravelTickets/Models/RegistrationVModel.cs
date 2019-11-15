using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelTickets.Models
{
	public class RegistrationVModel
	{
		
		
		public string FName { get; set; }
		public string SNAme { get; set; }
		public string LName { get; set; }
		public string Email { get; set; }

		[StringLength(20, MinimumLength = 5)]
		public string Password { get; set; }
		public string Country { get; set; }



	}
}
