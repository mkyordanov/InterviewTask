
public class InventoryService : IInventoryService
{
    private readonly IInventoryRepository _inventoryRepository;
    public InventoryService(IInventoryRepository inventoryRepository)
    {
        this._inventoryRepository = inventoryRepository;
    }

    public void AddInventory(InventoryRequestModel newInventory)
    {
        this._inventoryRepository.AddNewInventory(newInventory);
    }

    public List<InventoryManagment> GetALLInvetory()
    {
        return this._inventoryRepository.GetInventoryManagments();
    }

    public InventoryResponseModel UpdateInventory(InventoryRequestModel inventory)
    {
        throw new NotImplementedException();
    }
}