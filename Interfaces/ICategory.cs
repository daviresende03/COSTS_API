using COSTS_API.Models.Categories;

namespace COSTS_API.Interfaces
{
    public interface ICategory
    {
        Task<IEnumerable<Category>> FindAllAsync();
        Task<Category> FindByIdAsync(int id);
        Task<Category> FindByNameAsync(string name);
        Task<Category> InsertAsync(CategoryRequest categoryReq);
        Task<bool> RemoveAsync(Category category);
        Task<bool> ExistProjectWithThisCategory(Category category);
    }
}
