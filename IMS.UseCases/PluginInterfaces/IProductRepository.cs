namespace IMS.UseCases.PluginInterfaces;

using CoreBusiness;

public interface IProductRepository
{
	Task<IEnumerable<Product>> GetAllProductsAsync();
}