
using Data;

public class InventoryRepository : IInventoryRepository
{
    public InventoryRepository()
    {
        using (var context = new DataBaseContext())
        {
            var inventory = new List<InventoryManagment>(){
                new InventoryManagment{
                    Id= Guid.NewGuid(),
                    Name= "Name 1"
                    },
                    new InventoryManagment{
                    Id= Guid.NewGuid(),
                    Name= "Name 2"
                    },
                    new InventoryManagment{
                    Id= Guid.NewGuid(),
                    Name= "Name 3"
                    },
                    new InventoryManagment{
                    Id= Guid.NewGuid(),
                    Name= "Name 4"
                    },
            };
            context.AddRange(inventory);
            context.SaveChanges();
        }
    }

    public List<InventoryManagment> GetInventoryManagments()
    {
        using (var context = new DataBaseContext())
        {
            return context.InventoryManagments.ToList();
        }
    }

    public void AddNewInventory(InventoryRequestModel inventory)
    {
        using (var context = new DataBaseContext())
        {
            context.Add(new InventoryManagment
            {
                Id = Guid.NewGuid(),
                Name = inventory.Name
            });
            context.SaveChanges();
        };
    }

    public InventoryManagment UpdateInventoryItem(InventoryRequestModel inventory)
    {
        throw new NotImplementedException();

    }

    public InventoryManagment FindByid(Guid Id)
    {
        using (var context = new DataBaseContext())
        {
            return context.Find()



        }
    }
}
