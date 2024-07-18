namespace IMS.DBConnection;

using IMS.CoreBusiness;
using Microsoft.EntityFrameworkCore;

public class WarehouseDbContext : DbContext
{
	public WarehouseDbContext(DbContextOptions<WarehouseDbContext> options)
			: base(options)
	{
	}

	public DbSet<Product> Products { get; set; }
}