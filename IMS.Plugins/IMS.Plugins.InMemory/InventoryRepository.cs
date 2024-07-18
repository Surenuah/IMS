using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.Plugins.InMemory;

public class InventoryRepository : IInventoryRepository
{
	private readonly List<Inventory> _inventories;

	public InventoryRepository()
	{
		_inventories = new List<Inventory>()
		{
				new Inventory { ID = 1, Name = "Bike Seat", Quantity = 10, Price = 2 },
				new Inventory { ID = 2, Name = "Bike Body", Quantity = 10, Price = 15 },
				new Inventory { ID = 3, Name = "Bike Wheels", Quantity = 20, Price = 8 },
				new Inventory { ID = 4, Name = "Bike Pedels", Quantity = 20, Price = 1 },
		};
	}

	public async Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name)
	{
		if (string.IsNullOrWhiteSpace(name)) return await Task.FromResult(_inventories);

		return _inventories.Where(x => x.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
	}
}