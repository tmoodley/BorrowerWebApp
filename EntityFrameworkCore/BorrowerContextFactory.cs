using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace EntityFrameworkCore
{  
	public class CapitalMarketsContextFactory : IDesignTimeDbContextFactory<BorrowerDbContext>
	{
		public BorrowerDbContext CreateDbContext(string[] args)
		{
			var connection = @"Server=QAMSCMHDB1;Database=CapitalMarketsRMBS;Integrated Security=True;";
			var optionsBuilder = new DbContextOptionsBuilder<BorrowerDbContext>();
			optionsBuilder.UseSqlServer(connection);
			return new BorrowerDbContext(optionsBuilder.Options);
		}
	}
}
