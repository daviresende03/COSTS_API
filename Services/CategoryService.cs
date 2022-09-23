using COSTS_API.Infra.Data;
using COSTS_API.Interfaces;
using COSTS_API.Models.Categories;

namespace COSTS_API.Services
{
    public class CategoryService : ICategory
    {
        private readonly AppDbContext _context;
        public CategoryService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Category> FindByIdAsync(int id)
        {
            return _context.Categories.FirstOrDefault(x => x.Id == id);
        }

        public Task<Category> InsertAsync(CategoryRequest categoryReq)
        {
            throw new NotImplementedException();
        }
    }
}
