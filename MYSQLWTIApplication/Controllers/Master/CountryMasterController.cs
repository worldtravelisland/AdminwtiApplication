using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MYSQLWTIApplication.Controllers.Master
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryMasterController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllCountries()
        {
            return Ok("SuccessFull");
        }
    }
}
