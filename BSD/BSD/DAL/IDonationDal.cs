using BSD.Models;
using System.Data.Entity.Infrastructure;
using System.Drawing;

namespace BSD.DAL
{
    public interface IDonationDal
    {
        Task<Donation> Add(Donation donation);

        Task<Donation> Get(int id);

        Task<Donation> Remove(int id);
        Task<Donation> Update(Donation donation);

        Task<List<Gift>> GetProductsByDonationId(int donationId);
        public Task<List<Donation>> GetAllDonor();
       
    }
}
