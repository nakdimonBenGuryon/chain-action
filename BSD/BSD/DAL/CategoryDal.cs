using BSD.Models;

namespace BSD.DAL
{
    public class CategoryDal : ICategoryDal
    {
        private readonly Context context;
        public CategoryDal(Context Context)
        {
            this.context = Context;
        }
        public async Task< Category> Add(Category category)
        {
            try
            {
                await context.Categories.AddAsync(category);
                await context.SaveChangesAsync();
                return category;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Category Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Category Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
