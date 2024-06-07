using chinasA.Models;

namespace BSD.BLL
{
    public interface IPurchasServies
    {
        Purchase Add(Purchase gift);

        Purchase Get(int id);

        void Remove(int id);
        Purchase Update(Purchase Purchase);

        List<Purchase> GetProductsByCustomerId(int purchaseId);
    }
}
