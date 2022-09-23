using COSTS_API.Models.Categories;
using COSTS_API.Models.Services;

namespace COSTS_API.Models.Projects
{
    public class ProjectResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public decimal Cost { get; set; }
        public CategoryResponse Category { get; set; }
        public List<ServiceResponse> Services { get; set; } = new List<ServiceResponse>();
    }
}
