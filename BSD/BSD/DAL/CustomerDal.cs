using BSD.Models;
using Microsoft.EntityFrameworkCore;
namespace BSD.DAL
{
    public class CustomerDal : ICustomerDal
    {
        private readonly Context context;
        public CustomerDal(Context Context)
        {
            this.context = Context;
        }
        public async Task<Customer> Add(Customer customer)
        {
            await context.Customers.AddAsync(customer);
            await context.SaveChangesAsync();
            return customer;
        }

        public async Task<Customer> Get(string Email)
        {
            var v=  await context.Customers.FirstOrDefaultAsync(c => c.Email == Email);
            await context.SaveChangesAsync();
            return v;
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
