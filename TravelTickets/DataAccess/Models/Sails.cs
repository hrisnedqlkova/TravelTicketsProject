using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
	public class Sails :BaseModel
	{
		public Destinations Destinations { get; set; }
		public DateTime DateTime { get; set; }
		public Users User { get; set; }
		public double Price { get; set; }
	}
}
