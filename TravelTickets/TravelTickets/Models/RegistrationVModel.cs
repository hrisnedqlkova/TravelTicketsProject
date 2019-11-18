using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelTickets.Models
{
	public class RegistrationVModel
	{
		
		[Required]
		public string FName { get; set; }
		[Required]
		public string SNAme { get; set; }
		[Required]
		public string LName { get; set; }
		[Required]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[Required]
		[StringLength(20, MinimumLength = 5)]
		[DataType(DataType.Password)]
		public string Password { get; set; }
		[Required]
		[StringLength(20, MinimumLength = 5)]
		[DataType(DataType.Password)]
		public string ConfirmPassword { get; set; }
		[Required]
		public string Country { get; set; }



	}
}
