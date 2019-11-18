using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelTickets.Models
{
	public class LoginVModel
	{
		[Required]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }
		
		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }
	}
}
