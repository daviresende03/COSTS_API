using COSTS_API.Models.Categories;

namespace COSTS_API.Interfaces
{
    public interface ICategory
    { 
        Task<Category> FindByIdAsync(int id);
        Task<Category> InsertAsync(CategoryRequest categoryReq);
    }
}
