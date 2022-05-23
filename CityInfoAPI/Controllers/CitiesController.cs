using Microsoft.AspNetCore.Mvc;

namespace CityInfoAPI.Controllers
{
    [ApiController]
    public class CitiesController : ControllerBase
    {
        public JsonResult GetCities()
        {
            return new JsonResult(
                new List<object>
                {
                    new { id = 1,  Name = "Mumbai"},
                    new { id = 2, Name = "Bengaluru"}
                });
        }
    }
}
