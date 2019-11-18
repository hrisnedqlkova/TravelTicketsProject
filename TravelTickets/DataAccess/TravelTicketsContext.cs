using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
	public class TravelTicketsContext : DbContext
	{
		public DbSet<Destinations> Destinations { get; set; }
		public DbSet<LoginModel> LoginModels { get; set; }

		public DbSet<Prices> Prices { get; set; }
		public DbSet<role> Roles { get; set; }
		public DbSet<Sails> Sails { get; set; }
		public DbSet<Transport> Transport { get; set; }
		public DbSet<Users> Users { get; set; }



		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-CJ3R9AV;Initial Catalog=TravelTickets;Integrated Security=True;");
		}


	}
}
