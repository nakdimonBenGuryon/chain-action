using BSD.Models;

namespace BSD.BLL
{
    public interface ICategoryServies
    {
        Task< Category> Add(Category category);

        Category Get(int id);

        void Remove(int id);
        Category Update(Category category);
    }
}
