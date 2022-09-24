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

        public async Task<IEnumerable<Category>> FindAllAsync()
        {
            return _context.Categories.ToList();
        }

        public async Task<Category> FindByIdAsync(int id)
        {
            return _context.Categories.FirstOrDefault(x => x.Id == id);
        }

        public async Task<Category> FindByNameAsync(string name)
        {
            return _context.Categories.FirstOrDefault(x => x.Name == name);
        }

        public async Task<Category> InsertAsync(CategoryRequest categoryReq)
        {
            await _context.Categories.AddAsync(new Category { Name = categoryReq.Name});
            await _context.SaveChangesAsync();

            var obj = await FindByNameAsync(categoryReq.Name);
            return obj;
        }

        public async Task<bool> RemoveAsync(Category category)
        {
            try
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
