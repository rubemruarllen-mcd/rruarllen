using Microsoft.AspNetCore.Mvc;
using Pos.Service.Blazor.Domain;

namespace Pos.Service.Blazor.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ComponentsController : Controller
    {
        private readonly ComponentsContext _componentsContext;

        public ComponentsController(ComponentsContext componentsContext)
        {
            _componentsContext = componentsContext;
        }

        [HttpGet("GetQuantityComponents")]
        public IActionResult GetQuantityComponents()
        {
           return Ok(_componentsContext.Components.QuantityRazor);
        }

        [HttpGet("GetMenuComponents")]
        public IActionResult GetMenuComponents()
        {
            return Ok(_componentsContext.Components.MenuRazor);
        }
    }
}
