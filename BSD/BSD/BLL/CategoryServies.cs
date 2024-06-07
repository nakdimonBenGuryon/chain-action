using BSD.DAL;
using BSD.Models;
using chinasA.Models;

namespace BSD.BLL
{
    public class CategoryServies : ICategoryServies
    {
        private readonly ICategoryDal categoryDal;
        public CategoryServies(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }
        public async Task <Category> Add(Category category)
        {
            return await categoryDal.Add(category);
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

