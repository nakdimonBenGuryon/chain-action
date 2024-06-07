using AutoMapper;
using BSD.BLL;
using BSD.Models;
using BSD.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace BSD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController :ControllerBase
    {
        private readonly ICustomerServies customerServies;
        private readonly IMapper mapper;
        public CustomerController(ICustomerServies customerServies, IMapper mapper)
        {
            this.customerServies = customerServies;
            this.mapper = mapper;
        }
        [HttpPost] 
        public async Task<Customer> Add(CustomerDto customerDto)
        {
            var Customer = mapper.Map<Customer>(customerDto);
            return await customerServies.Add(Customer);

        }
        [HttpGet("get/{Email}")]
        public async Task<Customer> GetById(string email)
        {
            return await customerServies.Get(email);
        }
    }
}
