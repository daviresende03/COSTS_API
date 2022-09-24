using COSTS_API.Interfaces;
using COSTS_API.Models.Categories;
using COSTS_API.Models.Projects;
using COSTS_API.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace COSTS_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        private readonly IProject _projectService;
        public ProjectsController(IProject projServ)
        {
            _projectService = projServ;
        }
        
        [HttpGet("{id:int}",Name = "GetProject")]
        public async Task<IResult> Get([FromRoute] int id)
        {
            try
            {
                var result = await _projectService.FindByIdAsync(id);
                if (result == null)
                    return Results.NotFound("Id inexistente no banco de dados.");

                var proj = new ProjectResponse
                {
                    Id = result.Id,
                    Name = result.Name,
                    Budget = result.Budget,
                    Cost = result.Cost,
                    Category = new CategoryResponse
                    {
                        Id = result.Category.Id,
                        Name = result.Category.Name
                    }
                };
                foreach (var serv in result.Services)
                {
                    proj.Services.Add(new ServiceResponse
                    {
                        Id = serv.Id,
                        Name = serv.Name,
                        Description = serv.Descritpion,
                        Cost = serv.Cost
                    });
                }
                return Results.Ok(proj);
            }
            catch(Exception ex)
            {
                return Results.BadRequest(new { Mensagem = "Houve um erro ao recuperar o Projeto", Erro = $"{ex.Message}" });
            }
        }

        [HttpPost(Name = "PostProject")]
        public async Task<IResult> Post([FromBody] ProjectRequest projReq)
        {
            try
            {
                var result = await _projectService.InsertAsync(projReq);
                return Results.Created($"/projects/{result.Id}", result.Id);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(new { Mensagem = "Houve um erro ao recuperar o Projeto", Erro = $"{ex.Message}" });
            }
        }
    }
}