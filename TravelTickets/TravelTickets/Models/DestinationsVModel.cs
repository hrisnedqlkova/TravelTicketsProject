using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelTickets.Models
{
	public class DestinationsVModel
	{
		public string City { get; set; }
		public string Country { get; set; }

		public List<Transport> Transport { get; set; }

		public DestinationsVModel()
		{
			Transport = new List<Transport>();
		}

	}
}
