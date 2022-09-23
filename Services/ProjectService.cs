using COSTS_API.Infra.Data;
using COSTS_API.Interfaces;
using COSTS_API.Models.Projects;
using COSTS_API.Models.Services;

namespace COSTS_API.Services
{
    public class ProjectService : IProject
    {
        private readonly AppDbContext _context;
        public ProjectService(AppDbContext context)
        {
            _context = context;
        }

        public Task<Project> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Project> InsertAsync(ProjectRequest projectReq)
        {
            var obj = new Project
            {
                Id = NextProjectId().Result,
                Name = projectReq.Name,
                Budget = projectReq.Budget,
                Cost = projectReq.Cost,
                CategoryId = projectReq.CategoryId
                // Category = findById();
            };

            foreach(var service in projectReq.Services)
            {
                obj.Services.Add(new Service
                {
                    Name = service.Name,
                    Descritpion = service.Descritpion,
                    Cost = service.Cost,
                    ProjectId = obj.Id
                });
            }

            await _context.Projects.AddAsync(obj);
            obj.Services.ForEach(x => _context.Services.Add(x));
            await _context.SaveChangesAsync();

            return obj;
        }

        public async Task<int> NextProjectId()
        {
            return _context.Projects.Count() + 1;
        }
    }
}
