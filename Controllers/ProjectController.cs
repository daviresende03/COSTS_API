using COSTS_API.Interfaces;
using COSTS_API.Models.Projects;
using Microsoft.AspNetCore.Mvc;

namespace COSTS_API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProjectController : ControllerBase
    {
        private readonly IProject _projectService;
        public ProjectController(IProject projServ)
        {
            _projectService = projServ;
        }
        
        [HttpGet("{id:int}",Name = "GetProject")]
        public IResult Get([FromRoute] int id)
        {
            return Results.Ok("Tudo certo!");
        }

        [HttpPost(Name = "PostProject")]
        public async Task<IResult> Post([FromBody] ProjectRequest projReq)
        {
            var result = await _projectService.InsertAsync(projReq);
            return Results.Created($"/projects/{result.Id}", result.Id);
        }
    }
}