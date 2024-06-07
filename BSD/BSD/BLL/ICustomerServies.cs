using BSD.Models;

namespace BSD.BLL
{
    public interface ICustomerServies
    {
        Task<Customer> Add(Customer customer);

        Task<Customer> Get(string email);

        void Remove(int id);
        Customer Update(Customer customer);

        List<Customer> GetProductsByCustomerId(int customerId);
    }
}
