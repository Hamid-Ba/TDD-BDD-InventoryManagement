using Microsoft.AspNetCore.Mvc;
using Inventory_Application_Contract.InventoryAgg;

namespace Inventory_Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryApplication _application;

        public InventoryController(IInventoryApplication application) => _application = application;

        [HttpPost]
        public bool Create(InventoryDefineVM command)
        {
            try
            {
                return _application.Define(command);
            }
            catch
            {
                return false;
            }
        }
    }
}
