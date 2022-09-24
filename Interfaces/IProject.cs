using COSTS_API.Models.Projects;

namespace COSTS_API.Interfaces
{
    public interface IProject
    {
        Task<Project> FindByIdAsync(int id);
        Task<Project> InsertAsync(ProjectRequest projectReq);
        Task<Project> RemoveAsync(int id);
    }
}
