public interface IInventoryRepository
{
    List<InventoryManagment> GetInventoryManagments();
    void AddNewInventory(InventoryRequestModel inventory);

    InventoryManagment UpdateInventoryItem(InventoryRequestModel inventory);

    InventoryManagment FindByid(Guid Id);
}