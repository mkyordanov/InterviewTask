using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("inventory")]
public class InventoryController : Controller
{

    private readonly IInventoryService _inventoryService;
    public InventoryController(IInventoryService inventoryService)
    {
        this._inventoryService = inventoryService;
    }


    [HttpPost]
    public IActionResult AddInventory(InventoryRequestModel inventory)
    {

        if (string.IsNullOrEmpty(inventory.Name))
        {
            return BadRequest("Name cannot be empty or null");
        }

        this._inventoryService.AddInventory(inventory);
        return Ok();
    }
    [HttpGet]
    public IActionResult GetAllInventory()
    {

        var result = this._inventoryService.GetALLInvetory();
        return Ok(result);

    }
    [HttpPut]
    public IActionResult UpdateInventoryItem(InventoryRequestModel inventory)
    {
        if (string.IsNullOrEmpty(inventory.Guid))
        {
            return BadRequest("Please provide inventory id");
        }

        var itemToBeUpdated = this._inventoryService.FindByid(inventory.Guid);

        if (string.IsNullOrEmpty(inventory.Name))
        {
            return BadRequest("Please provide name to update the inventory item");
        }



        var updatedInventory = this._inventoryService.UpdateInventory(inventory);
        return Ok(updatedInventory);
    }


}