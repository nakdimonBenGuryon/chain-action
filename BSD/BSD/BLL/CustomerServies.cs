using BSD.DAL;
using BSD.Models;

namespace BSD.BLL
{
    public class CustomerServies : ICustomerServies
    {
        private readonly ICustomerDal customerDal;
        public CustomerServies(ICustomerDal customerDal)
        {
            this.customerDal = customerDal;
        }
        public async Task<Customer> Add(Customer customer)
        {
            return await customerDal.Add(customer);
        }

        public async Task< Customer> Get(string email)
        {
            return await customerDal.Get(email);
        }

        public List<Customer> GetProductsByCustomerId(int customerId)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Customer Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
