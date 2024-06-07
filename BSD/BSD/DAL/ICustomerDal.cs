using BSD.Models;

namespace BSD.DAL
{
    public interface ICustomerDal
    {
        Task<Customer> Add(Customer customer);

        Task<Customer> Get(string Email);
        void Remove(int id);
        Customer Update(Customer customer);

        List<Customer> GetProductsByCustomerId(int customerId);
    }
}
