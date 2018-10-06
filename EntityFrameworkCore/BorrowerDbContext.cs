using Data;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore
{
	public class BorrowerDbContext : DbContext
	{
		/* Define an IDbSet for each entity of the application */
		public DbSet<Borrower> Borrowers { get; set; }

		public BorrowerDbContext(DbContextOptions<BorrowerDbContext> options)
			: base(options)
		{

		}

		public BorrowerDbContext()
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		} 
	}
} 
