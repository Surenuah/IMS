using IMS.CoreBusiness;
using Microsoft.AspNetCore.Mvc;
using IMS.UseCases.PluginInterfaces;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
	private readonly IProductRepository _productRepository;

	public ProductsController(IProductRepository productRepository)
	{
		_productRepository = productRepository;
	}

	[HttpGet]
	public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
	{
		var products = await _productRepository.GetAllProductsAsync();
		return Ok(products);
	}
}