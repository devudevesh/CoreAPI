using Microsoft.AspNetCore.Mvc;

namespace CoreAPI.Controllers
{
    [Route("api/devesh/[controller]")]
    public class CribsController : ControllerBase
    {
        CustomerDbContext customerDbContext = new CustomerDbContext();

        [Route("GetAllCribs")]
        public IActionResult GetAllCribs()
        {
            var AllCribs = customerDbContext.Cribs;
            return Ok(AllCribs);
        }
    }
}