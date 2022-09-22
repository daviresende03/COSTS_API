using Microsoft.AspNetCore.Mvc;

namespace COSTS_API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProjectController : ControllerBase
    {
        
        [HttpGet("{int:id}",Name = "")]
        public IResult Get([FromRoute] int id)
        {
            return Results.Ok("Tudo certo!");
        }
    }
}