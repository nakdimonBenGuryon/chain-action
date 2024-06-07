using BSD.Models;
using Microsoft.EntityFrameworkCore.Internal;
//using System.Data.Entity;
using System.Drawing;
using Microsoft.EntityFrameworkCore;
namespace BSD.DAL
{
    public class GiftDal : IGiftDal
    {
        private readonly Context context;
        public GiftDal(Context Context)
        {
            this.context = Context;
        }
        public async Task<Gift> Add(Gift gift)
        {
            try
            {
                await context.Gifts.AddAsync(gift);
                await context.SaveChangesAsync();
                return gift;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async  Task<Gift> Get(int id)
        {
            var v = await context.Gifts.FirstOrDefaultAsync(c => c.Id == id);
            await context.SaveChangesAsync();
            return v;
        }

        public async Task<List<Gift>> GetGiftByDonationName(string DonationName)
        {
            var D = await context.Donations.FirstOrDefaultAsync(c => c.FirstName+ " " + c.LastName == DonationName);
            return await context.Gifts.Where(g => g.DonationId == D.Id).ToListAsync();
        }
        public async Task<List<Gift>> GetAllGift()
        {
            return await context.Gifts.ToListAsync();
        }

        public async Task<Donation> GetDonationByGiftId(int giftId)
        {
            var a=context.Gifts.FirstOrDefaultAsync(g => g.Id == giftId);
            return await context.Donations.FirstOrDefaultAsync(d => d.Id == a.Result.DonationId);
        }

        //public Task<List<Gift>> GetDonationByGiftId(int giftId)
        //{
        //    throw new NotImplementedException();
        //}

        //public void NumGiftAndDonation1()
        //{
        //    var a = (context.Gifts.GroupJoin(context.Donations, (G) => G.DonationId, (D) => D.Id, (G, D) => new { NameOfCategory = G.Category, names = D.Select((G) => G.FirstName + ' ' + G.LastName) })).ToList();
        //    foreach (var s in a)
        //    {
        //        Console.WriteLine("NameOfCategory " + s.NameOfCategory + ":");
        //        foreach (var employe in s.names)
        //            Console.WriteLine("\t" + "NameOfDonation: " + employe);
        //    }

        //}

        public async Task<Gift> Remove(int id)
        {
            try
            {
                Gift gift = await context.Gifts.FirstOrDefaultAsync(c => c.Id == id);
                if (gift == null)
                {
                    return null;//throw new Exception($"customer {id} not found");
                }
                context.Gifts.Remove(gift);
                await context.SaveChangesAsync();
                return gift;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<Gift> Update(Gift gift)
        {
            try
            {
                var G = await context.Gifts.FirstOrDefaultAsync(c => c.Id == gift.Id);
                if (G != null)
                {
                    if (G.DonationId != gift.DonationId && gift.DonationId != null)
                        G.DonationId = gift.DonationId;
                    if (G.CategoryId != gift.CategoryId && gift.CategoryId != 0)
                        G.CategoryId = gift.CategoryId;
                    if (G.Name != gift.Name || gift.Name != null)
                        G.Name = gift.Name;
                    if (G.Price != gift.Price || gift.Price != null)
                        G.Price = gift.Price;
                    await context.SaveChangesAsync();
                }
                return G;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //Task<List<Gift>> IGiftDal.NumGiftAndDonation()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
