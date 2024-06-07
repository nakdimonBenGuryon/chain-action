using BSD.Models;
using chinasA.Models;

namespace BSD.DAL
{
    public interface ICategoryDal
    {
      Task<Category>Add(Category category);

        Category Get(int id);

        void Remove(int id);
        Category Update(Category category);

       // List<Category>GetProductsByCustomerId(int categoryId);
    }
}
