namespace IMS.DBConnection;

using CoreBusiness;
using UseCases.PluginInterfaces;
using Microsoft.EntityFrameworkCore;

public class ProductRepository : IProductRepository
{
	private readonly WarehouseDbContext _context;

	public ProductRepository(WarehouseDbContext context)
	{
		_context = context;
	}

	public async Task<IEnumerable<Product>> GetAllProductsAsync()
	{
		return await _context.Products.ToListAsync();
	}
}