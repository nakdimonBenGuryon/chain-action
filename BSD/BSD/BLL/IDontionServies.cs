using BSD.Models;
using System.Drawing;

namespace BSD.BLL
{
    public interface IDontionServies
    {
        Task<Donation> Add(Donation donation);
        Task<Donation> Get(int id);
        Task<List<Gift>> GetProductsByDonationId(int DonationId);
        Task<Donation> Remove(int id);
        Task<Donation> Update(Donation donation);

        Task<List<Donation>> GetAllDonor();
    }
}
