public interface IInventoryService
{
    List<InventoryManagment> GetALLInvetory();
    void AddInventory(InventoryRequestModel newInventory);

    InventoryResponseModel UpdateInventory(InventoryRequestModel inventory);
}