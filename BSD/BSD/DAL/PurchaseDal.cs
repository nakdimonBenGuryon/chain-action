using BSD.Models;
using chinasA.Models;

namespace BSD.DAL
{
    public class PurchaseDal : IPurchaseDal
    {
        private readonly Context context;
        public PurchaseDal(Context Context)
        {
            this.context = Context;
        }
        public async Task<Purchase> Add(Purchase purchase)
        {
            try
            {
                await context.Purchases.AddAsync(purchase);
                await context.SaveChangesAsync();
                return purchase;
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

        //public async Task<Purchase> AddCardToPurches(Purchase purchase)
        //{
        //    try
        //    {

        //        await context.Purchases.AddAsync(purchase);.0
        //        await context.SaveChangesAsync();
        //        return purchase;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }

        //}

        public Purchase Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Purchase> GetProductsByCustomerId(int purchaseId)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Purchase Update(Purchase Purchase)
        {
            throw new NotImplementedException();
        }
    }
}
