using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webtraning.Models.Domain;

namespace Webtraning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetStudent()
        {

            var region = new List<Region>
            {
                new Region
                {
                    id=Guid.NewGuid(),
                    name="Elon",
                    code="ako",
                    RegionallmageUrl="sdmkc"
                },
                new Region
                {
                    id=Guid.NewGuid(),
                    name="Elon Mask",
                    code="ako123",
                    RegionallmageUrl="sdmkcdsa"
                }

            };
            return Ok(region);



        }

    }
}
