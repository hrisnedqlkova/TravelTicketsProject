using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
	public class Prices : BaseModel
	{
		public double Sum { get; set; }
		public Destinations Destinations { get; set; }
		public Transport Transport { get; set; }
	}
}
