using COSTS_API.Interfaces;
using COSTS_API.Models.Categories;
using Microsoft.AspNetCore.Mvc;

namespace COSTS_API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategory _categoryService;
        public CategoriesController(ICategory categServ)
        {
            _categoryService = categServ;
        }
        [HttpGet("{id:int}", Name = "GetCategories")]
        public async Task<IResult> Get([FromRoute] int id)
        {
            var result = await _categoryService.FindByIdAsync(id);
            if(result == null)
                return Results.NotFound("Id inexistente no banco de dados.");
            return Results.Ok(new CategoryResponse { Id = result.Id, Name = result.Name });
        }
    }
}
