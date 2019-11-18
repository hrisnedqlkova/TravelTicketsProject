using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
	public class LoginModel : BaseModel
	{
		public string Email { get; set; }
		public string Password { get; set; }
		public role Role { get; set; }
		public Users User { get; set; }


	}
}
