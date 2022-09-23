using COSTS_API.Models.Services;

namespace COSTS_API.Models.Projects
{
    public class ProjectRequest
    {
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public decimal Cost { get; set; }
        public int CategoryId { get; set; }
        public IEnumerable<ServiceRequest> Services { get; set; } = new List<ServiceRequest>();
    }
}
