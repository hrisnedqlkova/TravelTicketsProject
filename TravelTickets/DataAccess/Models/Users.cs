using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
	public class Users : BaseModel
	{
		public string FName { get; set; }
		public string SName { get; set; }
		public string LName { get; set; }
		public string Country { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }
		public string City { get; set; }
	}
}
