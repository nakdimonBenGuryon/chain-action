using AutoMapper;
using BSD.BLL;
using BSD.Models.DTO;
using BSD.Models;
using Microsoft.AspNetCore.Mvc;

namespace BSD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
    

        private readonly ICategoryServies categoryServies;
        private readonly IMapper mapper;
        public CategoryController(ICategoryServies categoryServies, IMapper mapper)
        {
            this.categoryServies = categoryServies;
            this.mapper = mapper;
        }
        [HttpPost]
        public async Task<Category> Add(CategoryDto categoryDto)
        {
            var category = mapper.Map<Category>(categoryDto);
            return await categoryServies.Add(category);

        }
    }
}
