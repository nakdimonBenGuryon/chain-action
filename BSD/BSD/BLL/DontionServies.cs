using BSD.DAL;
using BSD.Models;

namespace BSD.BLL
{
    public class DontionServies : IDontionServies
    {

        private readonly IDonationDal donationDal;
        public DontionServies(IDonationDal donationDal)
        {
            this.donationDal = donationDal;
        }
        async Task<Donation> IDontionServies.Add(Donation donation)
        {
            return await donationDal.Add(donation);
        }

        public async Task<Donation> Get(int id)
        {
            return await donationDal.Get(id);
        }

        public async Task<List<Donation>> GetAllDonor()
        {
            return await donationDal.GetAllDonor();
        }

        public async Task< List<Gift>> GetProductsByDonationId(int DonationId)
        {
           return await donationDal.GetProductsByDonationId(DonationId);
        }

        public async Task<Donation> Remove(int id)
        {
             return await donationDal.Remove(id);
            
        }

        async Task<Donation> IDontionServies.Update(Donation donation)
        {
            return await donationDal.Update(donation);
             
        }
    }
}
