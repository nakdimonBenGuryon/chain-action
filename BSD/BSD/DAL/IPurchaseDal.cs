using BSD.Models;
using chinasA.Models;

namespace BSD.DAL
{
    public interface IPurchaseDal
    {
        Task<Purchase> Add(Purchase purchase);

        Purchase Get(int id);

        void Remove(int id);
        Purchase Update(Purchase Purchase);

        List<Purchase> GetProductsByCustomerId(int purchaseId);
    }
}
