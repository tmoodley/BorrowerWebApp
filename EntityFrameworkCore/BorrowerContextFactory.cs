using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace EntityFrameworkCore
{  
	public class BorrowerContextFactory : IDesignTimeDbContextFactory<BorrowerDbContext>
	{
		public BorrowerDbContext CreateDbContext(string[] args)
		{
			var connection = @"Server=(localdb)\mssqllocaldb;Database=BorrowersDB;Trusted_Connection=True;ConnectRetryCount=0";
			var optionsBuilder = new DbContextOptionsBuilder<BorrowerDbContext>();
			optionsBuilder.UseSqlServer(connection);
			return new BorrowerDbContext(optionsBuilder.Options);
		}
	}
}
