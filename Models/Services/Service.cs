using COSTS_API.Models.Projects;

namespace COSTS_API.Models.Services
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descritpion { get; set; }
        public decimal Cost { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
