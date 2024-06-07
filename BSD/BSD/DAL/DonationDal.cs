using BSD.Models;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace BSD.DAL
{
    public class DonationDal : IDonationDal
    {
        private readonly Context context;
        public DonationDal(Context Context)
        {
            this.context = Context;
        }
        public async Task<Donation> Add(Donation donation)
        {
            try
            {
               await context.Donations.AddAsync(donation);
               await context.SaveChangesAsync();
               return donation;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

      
      
       
        public async Task<Donation> Get(int id)
        {
           var v=  await context.Donations.FirstOrDefaultAsync(c => c.Id == id);
            await context.SaveChangesAsync();
            return v;
        }

        public async Task<List<Donation>> GetAllDonor()
        {
            try { 
             var a=await (context.Donations.ToListAsync());
             return a;
            }
            catch
            {
                throw;
            }
            
        }

        public async Task<List<Gift>> GetProductsByDonationId(int donationId)
        {
            return await context.Gifts.Where(g => g.DonationId == donationId).ToListAsync();
      
        }

        public async Task<Donation> Remove(int id)
        {
            try { 
            Donation donation = await context.Donations.FirstOrDefaultAsync(c => c.Id == id);
            if (donation == null)
            {
                return null;//throw new Exception($"customer {id} not found");
            }
             context.Donations.Remove(donation);
            await context.SaveChangesAsync();
            return donation;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<Donation> Update(Donation donation)
        {
            try { 
            var D =  context.Donations.FirstOrDefault(c => c.Id == donation.Id);
            D.Email = donation.Email;
            D.FirstName = donation.FirstName;
            D.LastName = donation.LastName;
            D.Password = donation.Password;
            D.Phone = donation.Phone;
            await context.SaveChangesAsync();
            return D;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
