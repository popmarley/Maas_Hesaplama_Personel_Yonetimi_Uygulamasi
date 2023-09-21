using ARESDOKUM.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARESDOKUM.Context
{
	public class MyDbContext : DbContext
	{

		public DbSet<Employee> Employees { get; set; }
		public DbSet<Shift> Shifts { get; set; }
		public DbSet<Advance> Advances { get; set; }
		public DbSet<Leave> Leaves { get; set; }
		public DbSet<Payment> Payments { get; set; }
		public DbSet<User> Users { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=OZGUVEN ;Initial Catalog=AresDokum;Integrated Security=True");
		}
	}
}

